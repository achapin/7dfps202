using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ShootingControls : MonoBehaviour, FPSControls.IFPSActions
{
    [SerializeField] private Blaster[] Blasters;
    
    [SerializeField] private Image crosshair;
    [SerializeField] private Vector3 readySize;
    [SerializeField] private Vector3 unReadySize;
    
    private Blaster blaster;
    
    private FPSControls fpsControls;
    
    void Start()
    {
        fpsControls = new FPSControls();
        fpsControls.Enable();
        fpsControls.FPS.SetCallbacks(this);
        ActivateBlaster(0);
    }

    void Update()
    {
        crosshair.rectTransform.localScale = Vector3.Lerp(unReadySize, readySize, blaster.FirePercentage());
        crosshair.sprite = blaster.crosshairImage;
    }

    public void OnForwardMovement(InputAction.CallbackContext context) { }

    public void OnStrafe(InputAction.CallbackContext context) { }

    public void OnLook(InputAction.CallbackContext context) { }

    public void OnFire(InputAction.CallbackContext context)
    {
        if(!enabled) return;
        
        if (context.started)
        {
            blaster.StartFire();
        }

        if (context.canceled)
        {
            blaster.StopFire();
        }
    }

    public void OnSwitchWeapon1(InputAction.CallbackContext context)
    {
        ActivateBlaster(0);
    }

    public void OnSwitchWeapon2(InputAction.CallbackContext context)
    {
        ActivateBlaster(1);
    }

    public void OnSwitchWeapon3(InputAction.CallbackContext context)
    {
        ActivateBlaster(2);
    }

    public void OnSwitchWeapon4(InputAction.CallbackContext context)
    {
        ActivateBlaster(3);
    }

    private void ActivateBlaster(int index)
    {
        if (Blasters.Length <= index || Blasters[index] == null)
        {
            Debug.Log($"Don't have blaster {index}");
            return;
        }

        for (int blasterIndex = 0; blasterIndex < Blasters.Length; blasterIndex++)
        {
            Blasters[blasterIndex].gameObject.SetActive(index == blasterIndex);
        }
        blaster = Blasters[index];
    }
}
