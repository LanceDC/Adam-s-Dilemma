using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInspect : MonoBehaviour
{
    public float rotationSpeed = 2f;
    public Transform inspectLocation;
    public GameObject canvas;
    public Text nameText;
    public Text descriptionText;

    private PlayerController playerController;
    private PlayerInteract interact;
    private PlayerEvidence playerEvidence;
    private Camera cam;
    private PlayerControls controls;
    private Vector2 rotationInput;
    private Vector2 zoom;
    private bool inspectingObject = false;
    private Vector3 rotationPosition = Vector3.zero;

    [SerializeField] private Camera inspectCamera;
    [SerializeField] private GameObject announceEvidenceObj;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.General.ItemInspect.performed += ctx => InspectItem();
        controls.General.ItemInspect.performed += ctx => Inspect();

        controls.InspectObject.Rotation.performed += ctx => rotationInput = ctx.ReadValue<Vector2>();
        controls.InspectObject.Rotation.canceled += ctx => rotationInput = Vector2.zero;

        controls.InspectObject.Zoom.performed += ctx => zoom = ctx.ReadValue<Vector2>();
        controls.InspectObject.Zoom.canceled += ctx => zoom = Vector2.zero;

        controls.InspectObject.Return.performed += ctx => InspectItem();
        controls.InspectObject.Return.performed += ctx => Return();

    }

    void OnEnable()
    {
        controls.General.Enable();
    }

    void Start()
    {
        playerController = GetComponent<PlayerController>();
        playerEvidence = GetComponent<PlayerEvidence>();
        interact = GetComponent<PlayerInteract>();
        cam = GetComponentInChildren<Camera>();
    }

    void Update()
    {
        //Checking if the player is inspecting the object that they are currently holding so they can zoom and rotate the object
        if(PlayerInteract.IsHoldingItem)
        {
            if (!playerController.enabled)
            {
                RotateObject();
                CameraZoom();
            }
        }
    }

    
    private void Return()
    {
        if (PlayerInteract.IsHoldingItem)
        {
            controls.General.Enable();
            controls.InspectObject.Disable();
        }

        controls.General.Enable();
        controls.InspectObject.Disable();
    }
    
    private void Inspect()
    {
        if (PlayerInteract.IsHoldingItem)
        {
            controls.General.Disable();
            controls.InspectObject.Enable();
        }
    }

    private void InspectItem()
    {
        if (PlayerInteract.IsHoldingItem)
        {
            GameManager.PausePlayer();
            MoveHoldingItem();
        }
    }

    #region Inspecting Object
    private void RotateObject()
    {
        Vector3 rotation = new Vector3
        {
            y = rotationInput.x * rotationSpeed * Time.deltaTime,
            z = rotationInput.y * rotationSpeed * Time.deltaTime
        };
        
        
        GameObject holdingItem = PlayerInteract.GetHoldingItem();

        holdingItem.transform.RotateAround(rotationPosition, rotation, 1f); //rotationInput.x// + rotationInput.y);
    }

    public void CameraZoom()
    {
        inspectCamera.fieldOfView += -zoom.y * Time.deltaTime;
        inspectCamera.fieldOfView = Mathf.Clamp(inspectCamera.fieldOfView, 40f, 80f);
        
    }
    #endregion

    private void MoveHoldingItem()
    {
        //Either show the inspect screen or the main camera when the player has pressed the inspect button
        cam.enabled = !cam.enabled;
        inspectCamera.enabled = !inspectCamera.enabled;
        canvas.SetActive(!canvas.activeSelf);
        announceEvidenceObj.SetActive(false);

        GameObject holdingItem = PlayerInteract.GetHoldingItem();
        nameText.text = holdingItem.name;
        
        //When the object is being inspected and its tagged as evidence, add it to the list of found evidence
        if (holdingItem.CompareTag("Evidence"))
        {
            AnnounceEvidence(holdingItem);
            playerEvidence.AddEvidence(holdingItem);
        }


        //Change the positon of the obecjt from the player hand to the inspect location or vice versa 
        if (inspectingObject)//holdingItem.transform.position == inspectLocation.position)
        {
            holdingItem.transform.position = interact.holdPosition.position;
            holdingItem.transform.rotation = interact.holdPosition.rotation;
        }
        else
        {
            holdingItem.transform.position = inspectLocation.position;
        }
        inspectingObject = !inspectingObject;

        //Get the center of the mesh of the object that is being held
        rotationPosition = PlayerInteract.GetCenterOfHoldingObjectPosition();


        if (holdingItem.name != "Note")
            ItemDescription();
    }

    private void AnnounceEvidence(GameObject obj)
    {
        if(!playerEvidence.evidenceCollected.Contains(obj))
            announceEvidenceObj.SetActive(true);
    }

    public Vector3 RotateObject(GameObject obj)
    {
        //Inspect();

        Vector3 rotation = new Vector3
        {
            y = rotationInput.y * rotationSpeed * Time.deltaTime,
            z = rotationInput.x * rotationSpeed * Time.deltaTime
        };

        return rotation;
    }

    public void MoveHoldingItem(GameObject obj, Vector3 position)
    {
        cam.enabled = !cam.enabled;
        inspectCamera.enabled = !inspectCamera.enabled;
        canvas.SetActive(!canvas.activeSelf);
        nameText.text = obj.name;

        //controls.General.Disable();
        //controls.InspectObject.Enable();


        //if object is in inspectort position
        if (inspectingObject)//obj.transform.position == inspectLocation.position)
        {
            obj.transform.position = position;
            obj.transform.rotation = Quaternion.identity;
        }
        else
        {
            obj.transform.position = inspectLocation.position;
        }

        inspectingObject = !inspectingObject;

    }

    public void ItemDescription(string description = "")
    {
        descriptionText.text = description;
    }
}
