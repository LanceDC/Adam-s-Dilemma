using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.InputSystem;

public class ControlsTest : MonoBehaviour
{
    public PlayerControls controls;
    private InputAction movement;
    public InputActionAsset inputs;
    public Vector2 move;

    private void Awake()
    {
        controls = new PlayerControls();
        //Debug.Log(controls.General.Drop);
        ////movement = controls.General.Movement;
        //controls.General.Movement.performed += ctx => move = ctx.ReadValue<Vector2>();
        //controls.General.Movement.canceled += ctx => move = Vector2.zero;
        //controls.General.Movement.performed += MoveChange;
        //controls.General.ItemInteract.performed += ctx => Interact();
        ////move = controls.General.Movement.ReadValue<Vector2>();
        ////controls.General.MoveForward.
        ////movement.performed += MoveChange;
        //Debug.Log("awake");
        //Debug.Log(controls.General.Movement);
        controls.General.CameraMove.performed += ctx => move = ctx.ReadValue<Vector2>();

    }

    void OnEnable()
    {
        controls.General.Enable();
    }

    void OnDisable()
    {
        controls.General.Disable();
    }

    private void MoveChange(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Interact()
    {
        Debug.Log("interact");
    }
}
