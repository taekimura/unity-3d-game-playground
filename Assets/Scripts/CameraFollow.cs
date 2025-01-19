using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// A script for camera movement that smoothly follows a target and allows manual rotation using the mouse
public class CameraFollow : MonoBehaviour
{
    // PlayerActions to handle input
    private PlayerActions actions;

    // Horizontal mouse input value
    private float mouseX;

    // Offset between the camera and the target
    private Vector3 offset;

    // Speed of rotation when manually rotating the camera
    [SerializeField]
    private float rotationSpeed;

    // Speed of rotation when returning to the default camera position
    [SerializeField]
    private float returnSpeed;

    // The target the camera will follow
    [SerializeField]
    private Transform target;

    // The default camera position and rotation to return to
    [SerializeField]
    private Transform defaultTransform;

    // Smoothness of camera movement
    [SerializeField]
    [Range(0.01f, 1.0f)]
    private float smoothFactor;

    // Tracks whether the camera has been rotated manually
    private bool cameraRotated = false;

    // Called when the script instance is being loaded
    void Awake()
    {
        // Initialize input actions
        actions = new PlayerActions();

        // Bind the mouse movement input to update the mouseX variable
        actions.Controls.MouseMovement.performed += cxt => mouseX = cxt.ReadValue<float>();

        // Calculate the initial offset between the camera and the target
        offset = transform.position - target.transform.position;
    }

    void Start()
    {
        // Currently empty, but can be used for any setup needed at the start
    }

    void Update()
    {
        // Not used in this implementation but can handle other update logic
    }

    // Called after all Update calls; used here to handle camera movement
    private void LateUpdate()
    {
        if(!UIManager.MyInstance.MenuOpen)
        {
        // Check if the right mouse button is pressed for manual camera rotation
            if (Mouse.current.rightButton.isPressed)
            {
                cameraRotated = true;
            }

            // If the camera has been rotated and the right mouse button is released
            if (cameraRotated && !Mouse.current.rightButton.isPressed)
            {
                // Calculate the local position relative to the default transform
                Vector3 localPos = transform.InverseTransformPoint(defaultTransform.position);

                // Determine the rotation direction to return to the default position
                float xDirection = localPos.x < 0.0f ? 1 : -1; // -1 for counterclockwise

                // Rotate back to the default position
                Rotate(xDirection, returnSpeed);

                // Check if the camera is close enough to the default position
                if (Vector3.Distance(transform.position, defaultTransform.position) <= 0.1f && cameraRotated)
                {
                    // Set cameraRotated to true to reset the position and offset
                    cameraRotated = false;
                    transform.position = defaultTransform.position;
                    offset = transform.position - target.transform.position;
                }
            }
            else
            {
                // Rotate the camera based on mouse input
                Rotate(mouseX, rotationSpeed);
            }

            // Ensure the camera is always looking at the target
            transform.LookAt(target);
        }
    }


    // Rotates the camera around the target by a given amount and speed
    private void Rotate(float rotationAmount, float speed)
    {
        // Calculate the rotation as a quaternion
        Quaternion camTurnAngle = Quaternion.AngleAxis(rotationAmount * speed * Time.deltaTime, Vector3.up);

        // Apply the rotation to the offset
        offset = camTurnAngle * offset;

        // Calculate the new position of the camera based on the rotated offset
        Vector3 newPos = target.position + offset;

        // Smoothly move the camera to the new position
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
    }

    // Enable input actions when the script is enabled
    private void OnEnable()
    {
        actions.Enable();
    }

    // Disable input actions when the script is disabled
    private void OnDisable()
    {
        actions.Disable();
    }
}
