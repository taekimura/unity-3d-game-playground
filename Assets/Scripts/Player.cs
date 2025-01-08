using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    #region COMPONENTS
    [SerializeField]
    private CharacterController characterController;

    private PlayerActions actions;

    [SerializeField]
    private AnyStateAnimator animator;

    #endregion

    #region INPUT
    private Vector2 movementInput;

    private float horizontalMouseInput;

    #endregion

    #region VALUES

    [SerializeField]
    private float movementSpeed;

    [SerializeField]
    private float rotationSpeed;

    #endregion


    // Start is called before the first frame update
    private void Awake()
    {
        actions = new PlayerActions();
        actions.Controls.Move.performed += cxt => movementInput = cxt.ReadValue<Vector2>();
        actions.Controls.MouseMovement.performed += cxt => horizontalMouseInput = cxt.ReadValue<float>();
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Movement();
        Rotate();
    }

    private void Movement()
    {
        // move a character based on input 
        Vector3 movement = transform.right * movementInput.x + transform.forward * movementInput.y;

        characterController.Move(movement * movementSpeed * Time.deltaTime);

        if(movementInput.y != 0 || movementInput.x != 0)
        {
            animator.TryPlayAnimation("Walk");
            animator.onAnimationDone("Idle");
        }
        else
        {
            animator.onAnimationDone("Walk");
            animator.TryPlayAnimation("Idle");
        }
    }

    private void Rotate()
    {
        if(!Mouse.current.rightButton.isPressed){
            float mouseX = horizontalMouseInput * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * mouseX);
        }
    }

    private void OnEnable()
    {
        actions.Enable();
    }

    private void OnDisable()
    {
        actions.Disable();
    }
}
