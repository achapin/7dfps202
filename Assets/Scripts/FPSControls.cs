// GENERATED AUTOMATICALLY FROM 'Assets/FPS Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FPSControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FPSControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FPS Controls"",
    ""maps"": [
        {
            ""name"": ""FPS"",
            ""id"": ""c1f9b1ce-7272-4bf4-b950-33249d215fbc"",
            ""actions"": [
                {
                    ""name"": ""Forward Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a49675bd-8619-44e3-9dfc-15e50713bec2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Strafe"",
                    ""type"": ""Value"",
                    ""id"": ""f0b55556-1ad6-4605-8ab8-cf662f46129d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""21bb5b23-22e3-4755-8645-4746ecda5841"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""9388cb4a-d3ab-4747-9299-992d6a1b3ccf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Switch Weapon 1"",
                    ""type"": ""Button"",
                    ""id"": ""a65f14ed-4bf3-4a97-a625-a60eebf13fae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Switch Weapon 2"",
                    ""type"": ""Button"",
                    ""id"": ""7717879a-23cf-47e4-80a8-ff667e17ebdc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Switch Weapon 3"",
                    ""type"": ""Button"",
                    ""id"": ""4641b5a2-8ba4-4c6e-a556-959e44726ddf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Switch Weapon 4"",
                    ""type"": ""Button"",
                    ""id"": ""787ebc5e-1c89-4e0b-a7c9-319138008999"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1c0ff526-9e42-4b52-a0b2-6f2caf6d1e22"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""312c8b7c-cc27-494f-882c-31e669a52dbe"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Forward Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""99421ae4-ed06-457b-b529-ea9a229c34a1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Forward Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bf4e4753-abca-4480-97d4-15fb1bda96df"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Forward Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bd92f56-62b8-4c4e-b2c9-ec526f0957ac"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""db8a34b1-f558-4d56-a91d-8a9b0163cf86"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""897c415e-a4fc-46c2-a786-db33138b0a79"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c9695667-f0a1-4aa6-a66e-a027d7a15c24"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""87b6cf1d-938e-44bd-a661-11c0ac2598ce"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7708411-24f3-4222-82ae-fecf2e425725"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f977e59-1522-46d4-b6d8-7dbc2951f2cb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f77ea3a4-9d9f-4ae4-a97c-d09332906aa0"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de0d3247-06f5-45bd-8010-82e8396c42f5"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Weapon 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb356a3b-c9c3-4d93-a831-b29ab7eef5f0"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Weapon 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19f9c4d7-0e63-4edc-a071-5673a2d4df62"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Weapon 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a199f988-9eef-4c75-a139-f3500a91f52a"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Weapon 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c75cac8-99ff-4282-a858-a6fe17a4472c"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Weapon 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53a3e51b-7a77-4661-8a56-64d06b7b818b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Weapon 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d34d209-d1f9-407f-83e5-c58d3014dfa2"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Weapon 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0024e9f-06df-434e-8c08-15d68cfbd013"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Weapon 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
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
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // FPS
        m_FPS = asset.FindActionMap("FPS", throwIfNotFound: true);
        m_FPS_ForwardMovement = m_FPS.FindAction("Forward Movement", throwIfNotFound: true);
        m_FPS_Strafe = m_FPS.FindAction("Strafe", throwIfNotFound: true);
        m_FPS_Look = m_FPS.FindAction("Look", throwIfNotFound: true);
        m_FPS_Fire = m_FPS.FindAction("Fire", throwIfNotFound: true);
        m_FPS_SwitchWeapon1 = m_FPS.FindAction("Switch Weapon 1", throwIfNotFound: true);
        m_FPS_SwitchWeapon2 = m_FPS.FindAction("Switch Weapon 2", throwIfNotFound: true);
        m_FPS_SwitchWeapon3 = m_FPS.FindAction("Switch Weapon 3", throwIfNotFound: true);
        m_FPS_SwitchWeapon4 = m_FPS.FindAction("Switch Weapon 4", throwIfNotFound: true);
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

    // FPS
    private readonly InputActionMap m_FPS;
    private IFPSActions m_FPSActionsCallbackInterface;
    private readonly InputAction m_FPS_ForwardMovement;
    private readonly InputAction m_FPS_Strafe;
    private readonly InputAction m_FPS_Look;
    private readonly InputAction m_FPS_Fire;
    private readonly InputAction m_FPS_SwitchWeapon1;
    private readonly InputAction m_FPS_SwitchWeapon2;
    private readonly InputAction m_FPS_SwitchWeapon3;
    private readonly InputAction m_FPS_SwitchWeapon4;
    public struct FPSActions
    {
        private @FPSControls m_Wrapper;
        public FPSActions(@FPSControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ForwardMovement => m_Wrapper.m_FPS_ForwardMovement;
        public InputAction @Strafe => m_Wrapper.m_FPS_Strafe;
        public InputAction @Look => m_Wrapper.m_FPS_Look;
        public InputAction @Fire => m_Wrapper.m_FPS_Fire;
        public InputAction @SwitchWeapon1 => m_Wrapper.m_FPS_SwitchWeapon1;
        public InputAction @SwitchWeapon2 => m_Wrapper.m_FPS_SwitchWeapon2;
        public InputAction @SwitchWeapon3 => m_Wrapper.m_FPS_SwitchWeapon3;
        public InputAction @SwitchWeapon4 => m_Wrapper.m_FPS_SwitchWeapon4;
        public InputActionMap Get() { return m_Wrapper.m_FPS; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FPSActions set) { return set.Get(); }
        public void SetCallbacks(IFPSActions instance)
        {
            if (m_Wrapper.m_FPSActionsCallbackInterface != null)
            {
                @ForwardMovement.started -= m_Wrapper.m_FPSActionsCallbackInterface.OnForwardMovement;
                @ForwardMovement.performed -= m_Wrapper.m_FPSActionsCallbackInterface.OnForwardMovement;
                @ForwardMovement.canceled -= m_Wrapper.m_FPSActionsCallbackInterface.OnForwardMovement;
                @Strafe.started -= m_Wrapper.m_FPSActionsCallbackInterface.OnStrafe;
                @Strafe.performed -= m_Wrapper.m_FPSActionsCallbackInterface.OnStrafe;
                @Strafe.canceled -= m_Wrapper.m_FPSActionsCallbackInterface.OnStrafe;
                @Look.started -= m_Wrapper.m_FPSActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_FPSActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_FPSActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_FPSActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_FPSActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_FPSActionsCallbackInterface.OnFire;
                @SwitchWeapon1.started -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon1;
                @SwitchWeapon1.performed -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon1;
                @SwitchWeapon1.canceled -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon1;
                @SwitchWeapon2.started -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon2;
                @SwitchWeapon2.performed -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon2;
                @SwitchWeapon2.canceled -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon2;
                @SwitchWeapon3.started -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon3;
                @SwitchWeapon3.performed -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon3;
                @SwitchWeapon3.canceled -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon3;
                @SwitchWeapon4.started -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon4;
                @SwitchWeapon4.performed -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon4;
                @SwitchWeapon4.canceled -= m_Wrapper.m_FPSActionsCallbackInterface.OnSwitchWeapon4;
            }
            m_Wrapper.m_FPSActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ForwardMovement.started += instance.OnForwardMovement;
                @ForwardMovement.performed += instance.OnForwardMovement;
                @ForwardMovement.canceled += instance.OnForwardMovement;
                @Strafe.started += instance.OnStrafe;
                @Strafe.performed += instance.OnStrafe;
                @Strafe.canceled += instance.OnStrafe;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @SwitchWeapon1.started += instance.OnSwitchWeapon1;
                @SwitchWeapon1.performed += instance.OnSwitchWeapon1;
                @SwitchWeapon1.canceled += instance.OnSwitchWeapon1;
                @SwitchWeapon2.started += instance.OnSwitchWeapon2;
                @SwitchWeapon2.performed += instance.OnSwitchWeapon2;
                @SwitchWeapon2.canceled += instance.OnSwitchWeapon2;
                @SwitchWeapon3.started += instance.OnSwitchWeapon3;
                @SwitchWeapon3.performed += instance.OnSwitchWeapon3;
                @SwitchWeapon3.canceled += instance.OnSwitchWeapon3;
                @SwitchWeapon4.started += instance.OnSwitchWeapon4;
                @SwitchWeapon4.performed += instance.OnSwitchWeapon4;
                @SwitchWeapon4.canceled += instance.OnSwitchWeapon4;
            }
        }
    }
    public FPSActions @FPS => new FPSActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IFPSActions
    {
        void OnForwardMovement(InputAction.CallbackContext context);
        void OnStrafe(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnSwitchWeapon1(InputAction.CallbackContext context);
        void OnSwitchWeapon2(InputAction.CallbackContext context);
        void OnSwitchWeapon3(InputAction.CallbackContext context);
        void OnSwitchWeapon4(InputAction.CallbackContext context);
    }
}
