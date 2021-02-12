using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour, FPSControls.IFPSActions
{
    [SerializeField]
    private GameObject lookDolly = default;

    [SerializeField] private Vector2 lookSpeed = default;
    [SerializeField] private Vector2 moveSpeed = default;

    private Rigidbody myRigidbody;
    private Transform myTransform;
    private FPSControls fpsControls;

    private Vector3 moveVector;
    private Vector2 lookVector;
    
    private Vector2 minMaxLook = new Vector2(-85f, 85f);
    private float lookAngle = 0f;
    
    void Start()
    {
        myTransform = GetComponent<Transform>();
        fpsControls = new FPSControls();
        fpsControls.Enable();
        fpsControls.FPS.SetCallbacks(this);

        myRigidbody = GetComponent<Rigidbody>();
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        myTransform.RotateAround(transform.position, Vector3.up, lookVector.x * Time.deltaTime * lookSpeed.x);
        lookAngle = Mathf.Clamp(lookAngle + lookVector.y * Time.deltaTime * lookSpeed.y, minMaxLook.x, minMaxLook.y);
        lookDolly.transform.localRotation = Quaternion.Euler(-lookAngle, 0f, 0f);
        
        Vector3 translateVector = new Vector3(moveVector.x * moveSpeed.x, 0f, moveVector.z * moveSpeed.y);
        translateVector = myTransform.TransformDirection(translateVector) * Time.deltaTime;
        myRigidbody.MovePosition(translateVector + myTransform.position);
    }

    public void OnForwardMovement(InputAction.CallbackContext context)
    {
        moveVector.z = context.action.ReadValue<float>();
    }

    public void OnStrafe(InputAction.CallbackContext context)
    {
        moveVector.x = context.action.ReadValue<float>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        lookVector = context.action.ReadValue<Vector2>();
        lookVector = Vector3.ClampMagnitude(lookVector, 1f);
    }

    public void OnFire(InputAction.CallbackContext context) { }
    public void OnSwitchWeapon1(InputAction.CallbackContext context) { }

    public void OnSwitchWeapon2(InputAction.CallbackContext context) { }

    public void OnSwitchWeapon3(InputAction.CallbackContext context) { }

    public void OnSwitchWeapon4(InputAction.CallbackContext context) { }
}
