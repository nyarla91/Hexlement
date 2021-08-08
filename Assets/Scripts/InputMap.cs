// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMap.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMap : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""All"",
            ""id"": ""e6727019-cd73-4a73-b34c-d6ac30507347"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0d207aba-1684-4da6-9e97-1df9d9bc3598"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Delta"",
                    ""type"": ""Value"",
                    ""id"": ""97c81d02-94d0-4edb-a60e-57b0d803734f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""e99efeb8-df97-4fd6-b2d8-14dfc13f1af9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drag"",
                    ""type"": ""Button"",
                    ""id"": ""900ef85a-7e96-4eef-a94c-1abf78bfa8e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""b9ef4eba-4a8a-4c29-8b0b-53f68d50dc2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""56dd76c5-91e0-4538-9264-776133c230d5"",
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
                    ""id"": ""b7abcbe2-d70d-4405-8254-7ae361e906b1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""639a6cd2-7c08-48cc-b972-df45dcf3b839"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f12fab09-fcab-4e38-81e7-3cad08c709c4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a7660162-f789-4f0f-a2bc-cd3ca10e1f60"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""547f6b16-f343-4f90-83c1-e9fd6add9a90"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Delta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5d94bb8-6fb0-411f-b58b-8cd284cef552"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""QE"",
                    ""id"": ""4132bdfe-440c-4a03-8d8a-97b5b99b45fc"",
                    ""path"": ""1DAxis(minValue=-1250,maxValue=1250)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c7622a8b-1816-4b69-9466-03abc03845e7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b1092545-3694-4641-9b36-393d89758359"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8df0676a-249a-4309-bd98-2da8c25dbd3e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f147d1a4-5792-4388-8b24-a631c6f190a6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b884ba39-3902-48aa-93ba-76594d793f2b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Tap(duration=0.1)"",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7c17b51-b042-4d22-aa81-2f7b6a20e7c4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // All
        m_All = asset.FindActionMap("All", throwIfNotFound: true);
        m_All_Move = m_All.FindAction("Move", throwIfNotFound: true);
        m_All_Delta = m_All.FindAction("Delta", throwIfNotFound: true);
        m_All_Zoom = m_All.FindAction("Zoom", throwIfNotFound: true);
        m_All_Drag = m_All.FindAction("Drag", throwIfNotFound: true);
        m_All_Cancel = m_All.FindAction("Cancel", throwIfNotFound: true);
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

    // All
    private readonly InputActionMap m_All;
    private IAllActions m_AllActionsCallbackInterface;
    private readonly InputAction m_All_Move;
    private readonly InputAction m_All_Delta;
    private readonly InputAction m_All_Zoom;
    private readonly InputAction m_All_Drag;
    private readonly InputAction m_All_Cancel;
    public struct AllActions
    {
        private @InputMap m_Wrapper;
        public AllActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_All_Move;
        public InputAction @Delta => m_Wrapper.m_All_Delta;
        public InputAction @Zoom => m_Wrapper.m_All_Zoom;
        public InputAction @Drag => m_Wrapper.m_All_Drag;
        public InputAction @Cancel => m_Wrapper.m_All_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_All; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AllActions set) { return set.Get(); }
        public void SetCallbacks(IAllActions instance)
        {
            if (m_Wrapper.m_AllActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_AllActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_AllActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_AllActionsCallbackInterface.OnMove;
                @Delta.started -= m_Wrapper.m_AllActionsCallbackInterface.OnDelta;
                @Delta.performed -= m_Wrapper.m_AllActionsCallbackInterface.OnDelta;
                @Delta.canceled -= m_Wrapper.m_AllActionsCallbackInterface.OnDelta;
                @Zoom.started -= m_Wrapper.m_AllActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_AllActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_AllActionsCallbackInterface.OnZoom;
                @Drag.started -= m_Wrapper.m_AllActionsCallbackInterface.OnDrag;
                @Drag.performed -= m_Wrapper.m_AllActionsCallbackInterface.OnDrag;
                @Drag.canceled -= m_Wrapper.m_AllActionsCallbackInterface.OnDrag;
                @Cancel.started -= m_Wrapper.m_AllActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_AllActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_AllActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_AllActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Delta.started += instance.OnDelta;
                @Delta.performed += instance.OnDelta;
                @Delta.canceled += instance.OnDelta;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @Drag.started += instance.OnDrag;
                @Drag.performed += instance.OnDrag;
                @Drag.canceled += instance.OnDrag;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public AllActions @All => new AllActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IAllActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDelta(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnDrag(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
