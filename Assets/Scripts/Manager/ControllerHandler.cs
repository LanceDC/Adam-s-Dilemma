using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class ControllerHandler : MonoBehaviour
{
    public EventSystem eventSystem;
    public GameObject firstSelected;

    private Gamepad gamepad;
    private ControllerType type = ControllerType.MouseAndKeyboard;


    public static ControllerHandler instance;

    public static bool ControllerConnected
    {
        get
        {
            if (Gamepad.current != null)
                return true;
            else return false;
        }
    }


    public static ControllerType CurrentConnectedController
    {
        get
        {
            if (instance == null || !ControllerConnected)
                return ControllerType.MouseAndKeyboard;
            else
                return instance.type;
        }
    }

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetInputType();
    }

    // Update is called once per frame
    void Update()
    {
        if(Gamepad.current != gamepad)
        {
            SetInputType();
        }
        NoInputDeviceDetected();

    }

    public static void SetCurrentSelectedButtonGlobal(GameObject button)
    {
        instance.SetCurrentSelectedButton(button);
    }

    public void SetCurrentSelectedButton(GameObject button)
    {
        if(type == ControllerType.MouseAndKeyboard)
        {
            StartCoroutine(HighlightButton(null));
            return;
        }
        StartCoroutine(HighlightButton(button));
    }


    public IEnumerator HighlightButton(GameObject selectButton)
    {
        while (true)
        {
            eventSystem.SetSelectedGameObject(null);


            yield return new WaitForEndOfFrame();

            eventSystem.SetSelectedGameObject(selectButton);
            break;
        }
    }


    private void SetInputType()
    {
        gamepad = Gamepad.current;

        if (Gamepad.current != null)
        {
            if (gamepad.displayName == "Xbox Controller")
            {
                type = ControllerType.Xbox;
            }
            else
            {
                type = ControllerType.PlayStation;
            }

            eventSystem.SetSelectedGameObject(firstSelected);
        }
        else
        {
            eventSystem.SetSelectedGameObject(null);
        }
    }

    public static void SetControllerVibration(float lhs, float rhs)
    {
        if (ControllerConnected)
            instance.StartCoroutine(instance.ControllerVibration(lhs, rhs));
    }

    public static void SetControllerVibration(float lhs, float rhs, float duration)
    {
        instance.StartCoroutine(instance.ControllerVibration(lhs, rhs, duration));
    }

    public static void SetControllerVibration(float lhs, float rhs, WaitForSecondsRealtime secondsRealtime)
    {
        instance.StartCoroutine(instance.ControllerVibration(lhs, rhs, secondsRealtime));
    }

    private IEnumerator ControllerVibration(float lhs, float rhs)
    {
        gamepad.SetMotorSpeeds(lhs, rhs);
        yield return new WaitForSecondsRealtime(1f);
        gamepad.SetMotorSpeeds(0f, 0f);
    }

    private IEnumerator ControllerVibration(float lhs, float rhs, float duration)
    {
        gamepad.SetMotorSpeeds(lhs, rhs);
        yield return new WaitForSecondsRealtime(duration);
        gamepad.SetMotorSpeeds(0f, 0f);
    }

    private IEnumerator ControllerVibration(float lhs, float rhs, WaitForSecondsRealtime secondsRealtime)
    {
        gamepad.SetMotorSpeeds(lhs, rhs);
        yield return secondsRealtime;
        gamepad.SetMotorSpeeds(0f, 0f);
    }

    private void NoInputDeviceDetected()
    {
        if (!ControllerConnected && Mouse.current == null && Keyboard.current == null)
        {
            Debug.Log("There is no input device connected");
        }
    }
}

public enum ControllerType
{
    Xbox,
    PlayStation,
    MouseAndKeyboard
};
