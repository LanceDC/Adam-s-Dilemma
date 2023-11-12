using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    public Transform holdPosition;
    public float pickUpRange = 5f;
    public LayerMask pickUpLayer;

    [HideInInspector] public Vector3 objectCenter = Vector3.zero;

    private bool holdingItem = false;
    private Camera cam;
    private GameObject holdingObject;
    private PlayerControls controls;
    private Transform noteLocation;



    public  static PlayerInteract instance;

    public static bool IsHoldingItem
    {
        get
        {
            if (instance == null)
                return false;
            else
                return instance.holdingItem;
        }
    }
    public static float PickUpRange;
    public static Camera PlayerCamera;


    void Awake()
    {
        instance = this;
        controls = new PlayerControls();
        controls.General.PickUp.performed += ctx => InteractClick();
        controls.General.ItemAction.performed += ctx => ActionClick();

        PickUpRange = instance.pickUpRange;
        PlayerCamera = instance.cam;

    }

    void OnEnable()
    {
        controls.General.Enable();
    }

    void OnDisable()
    {
        controls.General.Disable();
    }

    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }




    private void InteractClick()
    {

        if (PlayerController.instance.enabled)
        {
            ///Interact with what the player is looking at,
            ///e.g. turn off and on light switch or press buttons on keypad
            InteractWithInteractible();

            //If the player is not holding an object and what they are looking can be picked up, pick it up
            if (!holdingItem && CheckPickUpable() != null)
            {
                PickUpItem();
            }
            else
            {
                DropItem();
            }
        }

    }

    private void ActionClick()
    {
        if (holdingItem)
        {
            ///If what they player is holding can do something, then do that action,
            ///e.g. turn on and off torch, take picture with camera
            IItemAction itemAction = holdingObject.GetComponent<IItemAction>();
            if (itemAction != null)
            {
                itemAction.ItemAction();
            }
        }
    }

    public void PickUpItem()
    {
        controls.InspectObject.Enable();

        holdingItem = true;

        //Set the oject that the player is holding is what they are looking at
        holdingObject = CheckPickUpable();

        if (holdingObject != null)
        {
            //Get the center of the mesh
            objectCenter = GetCenterOfHoldingObjectPosition();
            
            //Put the object in the hand location and rotation
            holdingObject.transform.position = holdPosition.position;
            holdingObject.transform.rotation = holdPosition.rotation;

            //Set the parent of the picked up object
            holdingObject.transform.parent = holdPosition;

            //Change the physics of the object so if it gets knocked it will stay in the hand
            holdingObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }


    public void DropItem()
    {
        controls.InspectObject.Disable();
        holdingItem = false;

        if (holdingObject != null)
        {
            objectCenter = Vector3.zero;
            holdingObject.transform.parent = null;
            holdingObject.GetComponent<Rigidbody>().isKinematic = false;
        }

    }

    private GameObject CheckPickUpable()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward * pickUpRange, out hit, pickUpRange, pickUpLayer))
        {
            return hit.transform.gameObject;
        }
        else return null;
    }


    public static GameObject GetHoldingItem()
    {
        return instance.holdingObject;
    }

    //Returns the center of the mesh
    public static Vector3 CenterOfHoldingObject()
    {
        return instance.objectCenter;
    }

    public static Vector3 GetCenterOfHoldingObjectPosition()
    {
        return instance.holdingObject.GetComponentInChildren<Renderer>().bounds.center;
    }

    private void InteractWithInteractible()
    {
        RaycastHit hit;
        Physics.Raycast(cam.transform.position, cam.transform.forward * pickUpRange, out hit, pickUpRange);

        if (hit.transform != null)
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}
