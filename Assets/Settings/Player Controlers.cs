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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b1442861-752b-406e-a4ff-01b5a1ded9da"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Looking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
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
                }
            ]
        },
        {
            ""name"": ""2D Game"",
            ""id"": ""2345cd75-f68a-4660-8c6f-6c56df78b3ca"",
            ""actions"": [],
            ""bindings"": []
        },
        {
            ""name"": ""UI"",
            ""id"": ""60e1aaf5-5e62-4204-b789-b73497d85f2f"",
            ""actions"": [],
            ""bindings"": []
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
        // 2D Game
        m__2DGame = asset.FindActionMap("2D Game", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
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
    public struct TourActionsActions
    {
        private @PlayerControlers m_Wrapper;
        public TourActionsActions(@PlayerControlers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Looking => m_Wrapper.m_TourActions_Looking;
        public InputAction @Movement => m_Wrapper.m_TourActions_Movement;
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
            }
        }
    }
    public TourActionsActions @TourActions => new TourActionsActions(this);

    // 2D Game
    private readonly InputActionMap m__2DGame;
    private I_2DGameActions m__2DGameActionsCallbackInterface;
    public struct _2DGameActions
    {
        private @PlayerControlers m_Wrapper;
        public _2DGameActions(@PlayerControlers wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m__2DGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_2DGameActions set) { return set.Get(); }
        public void SetCallbacks(I_2DGameActions instance)
        {
            if (m_Wrapper.m__2DGameActionsCallbackInterface != null)
            {
            }
            m_Wrapper.m__2DGameActionsCallbackInterface = instance;
            if (instance != null)
            {
            }
        }
    }
    public _2DGameActions @_2DGame => new _2DGameActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    public struct UIActions
    {
        private @PlayerControlers m_Wrapper;
        public UIActions(@PlayerControlers wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
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
    }
    public interface I_2DGameActions
    {
    }
    public interface IUIActions
    {
    }
}
