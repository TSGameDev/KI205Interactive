// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Player Controlers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controlers"",
    ""maps"": [
        {
            ""name"": ""Tour Actions"",
            ""id"": ""289be193-5e65-4b0a-81d1-5744456dde63"",
            ""actions"": [
                {
                    ""name"": ""Looking"",
                    ""type"": ""Value"",
                    ""id"": ""4b902351-18c3-4a34-8e7d-6ed209e521a4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""94381ea5-e781-48b8-9632-a0223915d85e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""8dc9fb7c-d3b0-4365-b1ab-b131d21edcd5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""9e4ca037-a74a-4088-b6ac-66fa42f978ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""d55f25d8-8474-480e-8072-fa19eabfb9f0"",
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
                    ""id"": ""0eb96bfc-8b4b-46bd-91ea-7310a710e2b6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d48250a1-595d-44b5-a41a-6e041791793b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b7c0e9f7-3c44-4d2a-a1d7-3709ea24a5f2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""be56d4d7-d4ea-4c09-be98-535d18b17922"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Game Pad"",
                    ""id"": ""42814955-7bae-470b-9e8c-82a05a32ef14"",
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
                    ""id"": ""e00c09be-aa75-4eed-8297-02e1e0a73e76"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e8427310-5a56-4734-877c-d18bec5209aa"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""39916344-e173-4114-b2ac-b50ba431a7d5"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7bc3e671-8d6d-45ac-bc90-b1db4632573b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ee14f5f5-372e-407c-92b9-7c57bc242f11"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12e1d143-4fcc-4208-87ef-240d5d212e2c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2fffc5b-77a5-4a2a-977d-2c4969cdc6ce"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Looking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c40d21c6-62d4-4647-9ba5-f35f3c99b91f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Looking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e1d1b69-bb48-4664-913b-d0b00541747d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dce32e39-c7c4-48a2-818b-3d178e604cf5"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""2D Game"",
            ""id"": ""2345cd75-f68a-4660-8c6f-6c56df78b3ca"",
            ""actions"": [
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""e9cf4d37-ed6d-4196-b6c6-6876b145b59b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""2947bd75-0990-4f5e-a5fb-6d74e331aeb8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b09eac66-835b-4fee-90ba-6320db1d4410"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fca04183-478f-452b-9578-bd1c67043d7d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""83cd9eed-e5f5-41f6-b6aa-201ba1769051"",
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
                    ""id"": ""96c114fd-dcbc-4789-95aa-95e693f5fe48"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""40287d55-17f8-49de-bf0e-a6833d83a035"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7918fcdb-f132-4f3c-a214-b81fabce015b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""50d36a97-c261-4b6b-9984-e7829ade78f9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Game Pad"",
                    ""id"": ""7092c68a-2200-41b3-aff3-cb7e6c40b4d0"",
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
                    ""id"": ""0586c228-8b83-4f98-84a1-a7a40ddefe5d"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a36869bf-e87f-45c8-bc0f-880bac252392"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b6c48158-6e21-49e9-9997-5efb16fbfb7c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1df7b08f-eed2-426a-b607-5d37e2ddd921"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""60e1aaf5-5e62-4204-b789-b73497d85f2f"",
            ""actions"": [
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""11dceacc-edac-47b2-bbff-062f55d8164a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c1f0ccd9-0484-4e18-a12e-5bc7a6fdfcf0"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62c852da-abab-4a28-a07f-5181b1733ae5"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse&Keyboard"",
            ""bindingGroup"": ""Mouse&Keyboard"",
            ""devices"": []
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        }
    ]
}");
        // Tour Actions
        m_TourActions = asset.FindActionMap("Tour Actions", throwIfNotFound: true);
        m_TourActions_Looking = m_TourActions.FindAction("Looking", throwIfNotFound: true);
        m_TourActions_Movement = m_TourActions.FindAction("Movement", throwIfNotFound: true);
        m_TourActions_Interaction = m_TourActions.FindAction("Interaction", throwIfNotFound: true);
        m_TourActions_Escape = m_TourActions.FindAction("Escape", throwIfNotFound: true);
        // 2D Game
        m__2DGame = asset.FindActionMap("2D Game", throwIfNotFound: true);
        m__2DGame_Escape = m__2DGame.FindAction("Escape", throwIfNotFound: true);
        m__2DGame_Movement = m__2DGame.FindAction("Movement", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Escape = m_UI.FindAction("Escape", throwIfNotFound: true);
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

    // Tour Actions
    private readonly InputActionMap m_TourActions;
    private ITourActionsActions m_TourActionsActionsCallbackInterface;
    private readonly InputAction m_TourActions_Looking;
    private readonly InputAction m_TourActions_Movement;
    private readonly InputAction m_TourActions_Interaction;
    private readonly InputAction m_TourActions_Escape;
    public struct TourActionsActions
    {
        private @PlayerControlers m_Wrapper;
        public TourActionsActions(@PlayerControlers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Looking => m_Wrapper.m_TourActions_Looking;
        public InputAction @Movement => m_Wrapper.m_TourActions_Movement;
        public InputAction @Interaction => m_Wrapper.m_TourActions_Interaction;
        public InputAction @Escape => m_Wrapper.m_TourActions_Escape;
        public InputActionMap Get() { return m_Wrapper.m_TourActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TourActionsActions set) { return set.Get(); }
        public void SetCallbacks(ITourActionsActions instance)
        {
            if (m_Wrapper.m_TourActionsActionsCallbackInterface != null)
            {
                @Looking.started -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnLooking;
                @Looking.performed -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnLooking;
                @Looking.canceled -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnLooking;
                @Movement.started -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnMovement;
                @Interaction.started -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnInteraction;
                @Escape.started -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_TourActionsActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_TourActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Looking.started += instance.OnLooking;
                @Looking.performed += instance.OnLooking;
                @Looking.canceled += instance.OnLooking;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public TourActionsActions @TourActions => new TourActionsActions(this);

    // 2D Game
    private readonly InputActionMap m__2DGame;
    private I_2DGameActions m__2DGameActionsCallbackInterface;
    private readonly InputAction m__2DGame_Escape;
    private readonly InputAction m__2DGame_Movement;
    public struct _2DGameActions
    {
        private @PlayerControlers m_Wrapper;
        public _2DGameActions(@PlayerControlers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Escape => m_Wrapper.m__2DGame_Escape;
        public InputAction @Movement => m_Wrapper.m__2DGame_Movement;
        public InputActionMap Get() { return m_Wrapper.m__2DGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_2DGameActions set) { return set.Get(); }
        public void SetCallbacks(I_2DGameActions instance)
        {
            if (m_Wrapper.m__2DGameActionsCallbackInterface != null)
            {
                @Escape.started -= m_Wrapper.m__2DGameActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m__2DGameActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m__2DGameActionsCallbackInterface.OnEscape;
                @Movement.started -= m_Wrapper.m__2DGameActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m__2DGameActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m__2DGameActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m__2DGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public _2DGameActions @_2DGame => new _2DGameActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Escape;
    public struct UIActions
    {
        private @PlayerControlers m_Wrapper;
        public UIActions(@PlayerControlers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Escape => m_Wrapper.m_UI_Escape;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Escape.started -= m_Wrapper.m_UIActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse&Keyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ITourActionsActions
    {
        void OnLooking(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
    public interface I_2DGameActions
    {
        void OnEscape(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnEscape(InputAction.CallbackContext context);
    }
}
