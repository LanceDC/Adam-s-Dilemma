using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[SelectionBase]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    [Range(0.1f, 1f)] public float mouseSensetivity;
    public float gravity = -9.81f;

    [HideInInspector] public CharacterController controller;


    private Vector2 cameraMove;
    private Vector2 playerMove;
    private Vector2 playerMoveGamepad;
    private Vector3 velocity;
    private float xRotation = 0f;
    private bool onGround;
    private PlayerControls controls;



    [SerializeField] private Transform cam;

    public static PlayerController instance;
    public static bool invertY = false;
    public static bool invertX = false;
    

    private void Awake()
    {
        instance = this;

        controls = new PlayerControls();

        controls.General.CameraMove.performed += ctx => cameraMove = ctx.ReadValue<Vector2>() * 5;
        controls.General.CameraMove.canceled += ctx => cameraMove = Vector2.zero;

        controls.General.Movement.performed += ctx => playerMove = ctx.ReadValue<Vector2>();
        controls.General.Movement.canceled += ctx => playerMove = Vector2.zero;

        controls.General.JoystickMove.performed += ctx => playerMoveGamepad = ctx.ReadValue<Vector2>();
        controls.General.JoystickMove.canceled += ctx => playerMoveGamepad = Vector2.zero;

        if(SaveSystem.LoadSettings() != null)
        {
            SetPlayerSettings(SaveSystem.LoadSettings());
        }

    }

    void OnEnable()
    {
        controls.General.Enable();
    }

    void OnDisable()
    {
        controls.General.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    private void MovePlayer()
    {
        float yStore = velocity.y;

        onGround = controller.isGrounded;

        if (onGround && yStore < 0)
        {
            yStore = -2f;
        }

        Vector2 move = playerMove + playerMoveGamepad;

        velocity = (Vector3.forward * move.y + Vector3.right * move.x);
        velocity = velocity.normalized * moveSpeed;
        velocity.y = yStore;

        velocity.y -= gravity * Time.deltaTime;
        velocity = transform.TransformDirection(velocity);

        controller.Move(velocity * Time.deltaTime);

    }

    private void RotatePlayer()
    {
        float horizontal = cameraMove.x * mouseSensetivity;

        float vertical = cameraMove.y * mouseSensetivity;

        if (invertX)
            horizontal = -horizontal;

        if (invertY)
            vertical = -vertical;

        xRotation -= vertical;
        xRotation = Mathf.Clamp(xRotation, -85f, 85f);


        cam.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * horizontal);
    }

    public static void SetPlayerSettings(SettingsData settings)
    {
        instance.mouseSensetivity = settings.sensitvity;
        invertX = settings.invertX;
        invertY = settings.invertY;
    }
}