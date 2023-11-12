using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Safe : Puzzle, IInteractable
{
    //array for code
    public float[] safeCode;
    public float leway = 0.5f;
    public float rotationSpeed = 5f;
    public Camera cam;
    public Camera inspectCamera;
    public Transform inspectLocation;
    public Text text;
    public Text nameText;
    public GameObject canvas;

    //number for current code to look for
    private int currentCodeToLookFor = 0;
    //bool to see if inspecting
    private bool isInspecting = false;
    private bool isUnlocked = false;
    private Vector3 normalPosition;
    private Quaternion normalRotation;
    private PlayerControls controls;
    private float inputRotation;
    //safehandle to set that as unlocked
    [SerializeField] private Transform dial;
    // Start is called before the first frame update

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Safe.Dial.performed += ctx => inputRotation = ctx.ReadValue<Vector2>().x;
        controls.Safe.Dial.canceled += ctx => inputRotation = 0f;

        controls.InspectObject.Return.performed += ctx => LeaveInspect();
    }

    void OnEnable()
    {
        controls.Safe.Enable();
        controls.InspectObject.Enable();
    }

    void OnDisable()
    {
        controls.Safe.Disable();
        controls.InspectObject.Disable();
    }


    void Start()
    {
        normalPosition = transform.position;
        normalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(isInspecting && !isUnlocked)
        {
            RotateDial();
        }


    }

    private void LeaveInspect()
    {
        if (isInspecting && !isUnlocked)
        {
            Interact();
        }
    }

    public void Interact()
    {

        //go into inspect, look at player inspector
        cam.enabled = !cam.enabled;
        inspectCamera.enabled = !inspectCamera.enabled;
        canvas.SetActive(!canvas.activeSelf);
        text.enabled = !text.enabled;
        nameText.text = name;


        if (transform.position == normalPosition)
        {
            transform.position = inspectLocation.position + new Vector3(0f, 0f, 3f);
            transform.Rotate(0f, 180f, 0f);
        }
        else
        {
            transform.position = normalPosition;
            transform.rotation = normalRotation;
        }

        //pause the player
        GameManager.PausePlayer();

        isInspecting = !isInspecting;

    }

    private void RotateDial()
    {
        dial.Rotate(0f, 0f, inputRotation * Time.deltaTime * rotationSpeed);
        CheckNumber(dial.localEulerAngles.z);

    }

    private void CheckNumber(float dialNumber)
    {
        float roundedNumber = Mathf.Round(dialNumber / 6);
        text.text = roundedNumber.ToString();//dialNumber.ToString();
        //check dial number against the fist code
        if(roundedNumber <= safeCode[currentCodeToLookFor] + leway && roundedNumber >= safeCode[currentCodeToLookFor] - leway)
        {
            currentCodeToLookFor++;
            Debug.Log("Got one point " + currentCodeToLookFor);

            if (currentCodeToLookFor == safeCode.Length)
            {
                isUnlocked = true;
                Interact();
                UnLockPuzzle();
                BoxCollider[] colliders = GetComponents<BoxCollider>();
                for (int i = 0; i < colliders.Length; i++)
                {
                    colliders[i].enabled = false;
                }
            }
        }
    }
}
