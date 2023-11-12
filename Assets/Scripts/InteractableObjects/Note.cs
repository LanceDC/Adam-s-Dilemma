using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Note : MonoBehaviour, IInteractable
{
    public GameObject inspectObject;
    [TextArea] public string description;

    private PlayerInspect inspect;
    private bool inspectingNote = false;
    private Vector3 inspectOriginalPosition;
    private PlayerControls controls;
    private Vector2 rotationInput;


    private void Awake()
    {
        controls = new PlayerControls();
        controls.InspectObject.Return.performed += ctx => InspectingNoteLeave();
        controls.InspectObject.Rotation.performed += ctx => rotationInput = ctx.ReadValue<Vector2>();
        controls.InspectObject.Rotation.canceled += ctx => rotationInput = Vector2.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        inspect = PlayerController.instance.GetComponent<PlayerInspect>();
        inspectOriginalPosition = inspectObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(inspectingNote)
        {
            inspect.CameraZoom();
            inspectObject.transform.Rotate(RotateObject(gameObject));
        }


    }

    public void Interact()
    {
        GameManager.PausePlayer();
        inspectingNote = !inspectingNote;
        inspect.MoveHoldingItem(inspectObject, inspectOriginalPosition);
        inspect.ItemDescription(description);

        controls.General.Disable();
        controls.InspectObject.Enable();
    }

    private void InspectingNoteLeave()
    {
        if (inspectingNote)
        {
            Interact();
            controls.InspectObject.Disable();
            controls.General.Enable();
        }
    }

    public Vector3 RotateObject(GameObject obj)
    {
        Vector3 rotation = new Vector3
        {
            y = rotationInput.y * 50 * Time.deltaTime,
            z = rotationInput.x * 50 * Time.deltaTime
        };

        return rotation;
    }
}
