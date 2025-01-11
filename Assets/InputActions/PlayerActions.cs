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
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""934883b2-1ee1-4f7e-b70c-58695ce504da"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e5c5ec50-a572-4673-be16-c8271fb46938"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""33449107-4561-4000-b5d0-fdd4826c97b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c37d588e-bf69-409d-8ba5-7932d2d4ea29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Wave"",
                    ""type"": ""Button"",
                    ""id"": ""0c05043b-28a3-44d9-9191-a52bb8a0e82c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""c3396e37-3585-4b69-a03e-87e71a05242c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
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
                },
                {
                    ""name"": """",
                    ""id"": ""8033a498-ceb6-4f21-acfe-428ee10abf52"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60431972-7882-40ab-8032-805d6189baef"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01c28aea-4436-4d0f-a097-f94d07f21585"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b4d8cb9-e561-4e4f-8471-b3d53f5ff84c"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Wave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6451608e-4f7a-4c9f-940b-f7e1ada39c0e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Controls
        m_Controls = asset.FindActionMap("Controls", throwIfNotFound: true);
        m_Controls_Move = m_Controls.FindAction("Move", throwIfNotFound: true);
        m_Controls_MouseMovement = m_Controls.FindAction("MouseMovement", throwIfNotFound: true);
        m_Controls_Run = m_Controls.FindAction("Run", throwIfNotFound: true);
        m_Controls_Jump = m_Controls.FindAction("Jump", throwIfNotFound: true);
        m_Controls_Wave = m_Controls.FindAction("Wave", throwIfNotFound: true);
        m_Controls_Aim = m_Controls.FindAction("Aim", throwIfNotFound: true);
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
    private readonly InputAction m_Controls_Move;
    private readonly InputAction m_Controls_MouseMovement;
    private readonly InputAction m_Controls_Run;
    private readonly InputAction m_Controls_Jump;
    private readonly InputAction m_Controls_Wave;
    private readonly InputAction m_Controls_Aim;
    public struct ControlsActions
    {
        private @PlayerActions m_Wrapper;
        public ControlsActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Controls_Move;
        public InputAction @MouseMovement => m_Wrapper.m_Controls_MouseMovement;
        public InputAction @Run => m_Wrapper.m_Controls_Run;
        public InputAction @Jump => m_Wrapper.m_Controls_Jump;
        public InputAction @Wave => m_Wrapper.m_Controls_Wave;
        public InputAction @Aim => m_Wrapper.m_Controls_Aim;
        public InputActionMap Get() { return m_Wrapper.m_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IControlsActions instance)
        {
            if (m_Wrapper.m_ControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMove;
                @MouseMovement.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMouseMovement;
                @MouseMovement.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMouseMovement;
                @MouseMovement.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMouseMovement;
                @Run.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnJump;
                @Wave.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnWave;
                @Wave.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnWave;
                @Wave.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnWave;
                @Aim.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MouseMovement.started += instance.OnMouseMovement;
                @MouseMovement.performed += instance.OnMouseMovement;
                @MouseMovement.canceled += instance.OnMouseMovement;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Wave.started += instance.OnWave;
                @Wave.performed += instance.OnWave;
                @Wave.canceled += instance.OnWave;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
            }
        }
    }
    public ControlsActions @Controls => new ControlsActions(this);
    public interface IControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMouseMovement(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnWave(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
}
