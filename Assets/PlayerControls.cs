// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""General"",
            ""id"": ""2ed0eedc-c1a8-4b7f-91dd-62417a465598"",
            ""actions"": [
                {
                    ""name"": ""Joystick Move"",
                    ""type"": ""Value"",
                    ""id"": ""149faca8-741a-4b6f-9b62-44d2e8493eeb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone(min=0.25,max=0.85),ScaleVector2(x=8,y=8)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMove"",
                    ""type"": ""Value"",
                    ""id"": ""739f8ff3-e5c7-4dd7-93be-2b5e7dbfc6d1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item Inspect"",
                    ""type"": ""Button"",
                    ""id"": ""82e2666a-8ff2-4626-864b-d1c14af6783c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""184ee947-009a-46da-9bbb-7bdb44d47755"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""8e6cc591-bfeb-4cf3-ae0e-4634d87df3d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ItemAction"",
                    ""type"": ""Button"",
                    ""id"": ""5bd6b1f0-86a3-437c-b569-5cddb705a664"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""39ce2ec5-095a-48ae-9fa7-bd2fcd351c12"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a93e1d4d-cd5a-44be-9b92-0800ae028b3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ab5848bd-b87a-47a2-a0ce-522ffa8d1b0f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joystick Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46ebf18e-8b26-47ac-8a85-b1e2180a3755"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""542e6056-12c6-465a-adca-b770cdee5407"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e7de5cf-c1fc-4a85-9477-e7aeab372fd3"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item Inspect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c156c1a0-f059-4841-b7f8-aa015357b923"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item Inspect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8743d9c8-734d-4886-be47-45e950f3815b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d96726da-d31b-4b77-9764-57077ef110d7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14095297-60a9-4b38-bc22-169229eac49b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afde6528-4cbe-479f-b1bf-a9061c1b4add"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aecd0a44-0e6c-4926-965c-cf187ee32519"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ItemAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62d82fe0-4230-4e06-801f-1c0a74c4627a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ItemAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Movement"",
                    ""id"": ""01717a6a-44b9-435b-a670-1161ef44a406"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""63c06608-8c6d-48c5-b1e6-e5e27e34564e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1356be29-caf5-491d-9384-280f40f6a770"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e50f38e1-8356-4d18-941c-9483a343cedb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ffb779f1-2752-4617-9eb9-6f8e75ab65ad"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7138632b-028a-478e-851c-bb37eb096bd8"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c459febb-e863-4482-b175-e4fdca2fb28a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InspectObject"",
            ""id"": ""300d035e-51e3-443f-9e6e-a5cd3da926ea"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""dd5a9491-f0dd-4f6d-99d2-12f9ec9b4041"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""dfff846f-9928-4fe2-9a89-13f14a091526"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Return"",
                    ""type"": ""Button"",
                    ""id"": ""cf04fdf1-9992-411c-b977-366d5ae1cdc2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""10f97211-5ada-406b-af87-5794fb890627"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""82a66aac-d3e5-403e-8bf7-b08ce9b3b32e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5da0529e-d4e2-4322-b847-cc038f98f141"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""48ece7b0-e983-4cea-8ff5-2eeb94e08780"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1d71b911-39d2-43d3-9314-e159cda736b2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""be953f86-c304-42ca-b007-cb94ccbc8240"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aaa3edca-5b15-4c86-b28e-88777d564978"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=10,y=10)"",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae5348b6-aa5e-4cc5-a3c2-cc898af330f4"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b58e4de9-4301-4f99-b6ed-77f31c083f53"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68f60864-8147-4e50-a4d7-a74c8c16d409"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Safe"",
            ""id"": ""29e3a123-d24e-4b2f-9e45-437d4ba5a100"",
            ""actions"": [
                {
                    ""name"": ""Dial"",
                    ""type"": ""Value"",
                    ""id"": ""70d56edb-10cc-4334-86be-c71f9c579f68"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5aed4aa0-d41f-44cd-b32d-41329a56492f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dial"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""738ae71a-74b8-4de0-984d-5fec6a3de5f6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dbd7d201-bd55-488b-bcc6-46fa816893c3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2a3aa1ca-fcad-408b-88fc-f79eb0f878d7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d61f2a0a-7393-464b-816b-7840b45da265"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""25e534cf-695f-4169-bfba-6fe8344ce958"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // General
        m_General = asset.FindActionMap("General", throwIfNotFound: true);
        m_General_JoystickMove = m_General.FindAction("Joystick Move", throwIfNotFound: true);
        m_General_CameraMove = m_General.FindAction("CameraMove", throwIfNotFound: true);
        m_General_ItemInspect = m_General.FindAction("Item Inspect", throwIfNotFound: true);
        m_General_PickUp = m_General.FindAction("PickUp", throwIfNotFound: true);
        m_General_Drop = m_General.FindAction("Drop", throwIfNotFound: true);
        m_General_ItemAction = m_General.FindAction("ItemAction", throwIfNotFound: true);
        m_General_Movement = m_General.FindAction("Movement", throwIfNotFound: true);
        m_General_Pause = m_General.FindAction("Pause", throwIfNotFound: true);
        // InspectObject
        m_InspectObject = asset.FindActionMap("InspectObject", throwIfNotFound: true);
        m_InspectObject_Rotation = m_InspectObject.FindAction("Rotation", throwIfNotFound: true);
        m_InspectObject_Zoom = m_InspectObject.FindAction("Zoom", throwIfNotFound: true);
        m_InspectObject_Return = m_InspectObject.FindAction("Return", throwIfNotFound: true);
        // Safe
        m_Safe = asset.FindActionMap("Safe", throwIfNotFound: true);
        m_Safe_Dial = m_Safe.FindAction("Dial", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // General
    private readonly InputActionMap m_General;
    private IGeneralActions m_GeneralActionsCallbackInterface;
    private readonly InputAction m_General_JoystickMove;
    private readonly InputAction m_General_CameraMove;
    private readonly InputAction m_General_ItemInspect;
    private readonly InputAction m_General_PickUp;
    private readonly InputAction m_General_Drop;
    private readonly InputAction m_General_ItemAction;
    private readonly InputAction m_General_Movement;
    private readonly InputAction m_General_Pause;
    public struct GeneralActions
    {
        private @PlayerControls m_Wrapper;
        public GeneralActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @JoystickMove => m_Wrapper.m_General_JoystickMove;
        public InputAction @CameraMove => m_Wrapper.m_General_CameraMove;
        public InputAction @ItemInspect => m_Wrapper.m_General_ItemInspect;
        public InputAction @PickUp => m_Wrapper.m_General_PickUp;
        public InputAction @Drop => m_Wrapper.m_General_Drop;
        public InputAction @ItemAction => m_Wrapper.m_General_ItemAction;
        public InputAction @Movement => m_Wrapper.m_General_Movement;
        public InputAction @Pause => m_Wrapper.m_General_Pause;
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
            {
                @JoystickMove.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnJoystickMove;
                @JoystickMove.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnJoystickMove;
                @JoystickMove.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnJoystickMove;
                @CameraMove.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnCameraMove;
                @CameraMove.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnCameraMove;
                @CameraMove.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnCameraMove;
                @ItemInspect.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnItemInspect;
                @ItemInspect.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnItemInspect;
                @ItemInspect.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnItemInspect;
                @PickUp.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPickUp;
                @PickUp.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPickUp;
                @PickUp.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPickUp;
                @Drop.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnDrop;
                @ItemAction.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnItemAction;
                @ItemAction.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnItemAction;
                @ItemAction.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnItemAction;
                @Movement.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMovement;
                @Pause.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GeneralActionsCallbackInterface = instance;
            if (instance != null)
            {
                @JoystickMove.started += instance.OnJoystickMove;
                @JoystickMove.performed += instance.OnJoystickMove;
                @JoystickMove.canceled += instance.OnJoystickMove;
                @CameraMove.started += instance.OnCameraMove;
                @CameraMove.performed += instance.OnCameraMove;
                @CameraMove.canceled += instance.OnCameraMove;
                @ItemInspect.started += instance.OnItemInspect;
                @ItemInspect.performed += instance.OnItemInspect;
                @ItemInspect.canceled += instance.OnItemInspect;
                @PickUp.started += instance.OnPickUp;
                @PickUp.performed += instance.OnPickUp;
                @PickUp.canceled += instance.OnPickUp;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
                @ItemAction.started += instance.OnItemAction;
                @ItemAction.performed += instance.OnItemAction;
                @ItemAction.canceled += instance.OnItemAction;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GeneralActions @General => new GeneralActions(this);

    // InspectObject
    private readonly InputActionMap m_InspectObject;
    private IInspectObjectActions m_InspectObjectActionsCallbackInterface;
    private readonly InputAction m_InspectObject_Rotation;
    private readonly InputAction m_InspectObject_Zoom;
    private readonly InputAction m_InspectObject_Return;
    public struct InspectObjectActions
    {
        private @PlayerControls m_Wrapper;
        public InspectObjectActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_InspectObject_Rotation;
        public InputAction @Zoom => m_Wrapper.m_InspectObject_Zoom;
        public InputAction @Return => m_Wrapper.m_InspectObject_Return;
        public InputActionMap Get() { return m_Wrapper.m_InspectObject; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InspectObjectActions set) { return set.Get(); }
        public void SetCallbacks(IInspectObjectActions instance)
        {
            if (m_Wrapper.m_InspectObjectActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_InspectObjectActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_InspectObjectActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_InspectObjectActionsCallbackInterface.OnRotation;
                @Zoom.started -= m_Wrapper.m_InspectObjectActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_InspectObjectActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_InspectObjectActionsCallbackInterface.OnZoom;
                @Return.started -= m_Wrapper.m_InspectObjectActionsCallbackInterface.OnReturn;
                @Return.performed -= m_Wrapper.m_InspectObjectActionsCallbackInterface.OnReturn;
                @Return.canceled -= m_Wrapper.m_InspectObjectActionsCallbackInterface.OnReturn;
            }
            m_Wrapper.m_InspectObjectActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @Return.started += instance.OnReturn;
                @Return.performed += instance.OnReturn;
                @Return.canceled += instance.OnReturn;
            }
        }
    }
    public InspectObjectActions @InspectObject => new InspectObjectActions(this);

    // Safe
    private readonly InputActionMap m_Safe;
    private ISafeActions m_SafeActionsCallbackInterface;
    private readonly InputAction m_Safe_Dial;
    public struct SafeActions
    {
        private @PlayerControls m_Wrapper;
        public SafeActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Dial => m_Wrapper.m_Safe_Dial;
        public InputActionMap Get() { return m_Wrapper.m_Safe; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SafeActions set) { return set.Get(); }
        public void SetCallbacks(ISafeActions instance)
        {
            if (m_Wrapper.m_SafeActionsCallbackInterface != null)
            {
                @Dial.started -= m_Wrapper.m_SafeActionsCallbackInterface.OnDial;
                @Dial.performed -= m_Wrapper.m_SafeActionsCallbackInterface.OnDial;
                @Dial.canceled -= m_Wrapper.m_SafeActionsCallbackInterface.OnDial;
            }
            m_Wrapper.m_SafeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Dial.started += instance.OnDial;
                @Dial.performed += instance.OnDial;
                @Dial.canceled += instance.OnDial;
            }
        }
    }
    public SafeActions @Safe => new SafeActions(this);
    public interface IGeneralActions
    {
        void OnJoystickMove(InputAction.CallbackContext context);
        void OnCameraMove(InputAction.CallbackContext context);
        void OnItemInspect(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
        void OnItemAction(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IInspectObjectActions
    {
        void OnRotation(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnReturn(InputAction.CallbackContext context);
    }
    public interface ISafeActions
    {
        void OnDial(InputAction.CallbackContext context);
    }
}
