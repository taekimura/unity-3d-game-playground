// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Controls"",
            ""id"": ""6542e516-d7b8-4f59-b5d9-e3a656c046be"",
            ""actions"": [
                {
                    ""name"": ""Idle"",
                    ""type"": ""Button"",
                    ""id"": ""1af01e71-8a06-45a6-9b92-f8f790e2e693"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Battle"",
                    ""type"": ""Button"",
                    ""id"": ""abc95383-16f2-4b67-ac68-15748a344a5e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""934883b2-1ee1-4f7e-b70c-58695ce504da"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9dbbb189-50ec-4c14-8ad7-1f46485a68a9"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Idle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b044c5f-0631-4269-8e26-dfc029c544ff"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Battle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""cd907bc6-1f39-4fd2-8b17-d1ce2cf50f57"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""39757b34-e8f2-4439-bd79-9dc98699741a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6d93a3f9-4bdb-43bf-8fe5-2026f3b905c6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b511cbb4-1945-410c-aafc-6333a1b3c850"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ba243bec-30f5-4442-9a7c-703c86e514c4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Controls
        m_Controls = asset.FindActionMap("Controls", throwIfNotFound: true);
        m_Controls_Idle = m_Controls.FindAction("Idle", throwIfNotFound: true);
        m_Controls_Battle = m_Controls.FindAction("Battle", throwIfNotFound: true);
        m_Controls_Move = m_Controls.FindAction("Move", throwIfNotFound: true);
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

    // Controls
    private readonly InputActionMap m_Controls;
    private IControlsActions m_ControlsActionsCallbackInterface;
    private readonly InputAction m_Controls_Idle;
    private readonly InputAction m_Controls_Battle;
    private readonly InputAction m_Controls_Move;
    public struct ControlsActions
    {
        private @PlayerActions m_Wrapper;
        public ControlsActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Idle => m_Wrapper.m_Controls_Idle;
        public InputAction @Battle => m_Wrapper.m_Controls_Battle;
        public InputAction @Move => m_Wrapper.m_Controls_Move;
        public InputActionMap Get() { return m_Wrapper.m_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IControlsActions instance)
        {
            if (m_Wrapper.m_ControlsActionsCallbackInterface != null)
            {
                @Idle.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnIdle;
                @Idle.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnIdle;
                @Idle.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnIdle;
                @Battle.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnBattle;
                @Battle.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnBattle;
                @Battle.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnBattle;
                @Move.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Idle.started += instance.OnIdle;
                @Idle.performed += instance.OnIdle;
                @Idle.canceled += instance.OnIdle;
                @Battle.started += instance.OnBattle;
                @Battle.performed += instance.OnBattle;
                @Battle.canceled += instance.OnBattle;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public ControlsActions @Controls => new ControlsActions(this);
    public interface IControlsActions
    {
        void OnIdle(InputAction.CallbackContext context);
        void OnBattle(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
