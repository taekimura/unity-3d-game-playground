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
    private AnyStateAnimator anyStateAnimator;

    #endregion

    #region INPUT
    private Vector2 movementInput;

    private float horizontalMouseInput;

    #endregion

    #region ANIMATION
    [SerializeField]
    private float animationSmoothTime;
    private Vector2 animationVector;
    #endregion

    #region VALUES

    [SerializeField]
    private float walkSpeed;
    [SerializeField]
    private float runSpeed;
    
    private float currentSpeed;

    [SerializeField]
    private float rotationSpeed;

    private bool isRunning;

    #endregion


    // Start is called before the first frame update
    private void Awake()
    {

        currentSpeed = walkSpeed;
        actions = new PlayerActions();
        actions.Controls.Move.performed += cxt => movementInput = cxt.ReadValue<Vector2>();
        actions.Controls.MouseMovement.performed += cxt => horizontalMouseInput = cxt.ReadValue<float>();
        actions.Controls.Run.performed += cxt => Run();
        actions.Controls.Jump.performed += cxt => Jump();
    }

    // Start is called before the first frame update
    private void Start()
    {
        AnyStateAnimation idle = new AnyStateAnimation("Idle", "Jump");
        AnyStateAnimation walk = new AnyStateAnimation("Walk", "Jump");
        AnyStateAnimation run = new AnyStateAnimation("Run", "Jump");
        AnyStateAnimation jump = new AnyStateAnimation("Jump");

        anyStateAnimator.AddAnimation(idle, walk, run, jump);
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

        animationVector = Vector2.MoveTowards(animationVector, movementInput, animationSmoothTime* Time.deltaTime);

        characterController.Move(movement * currentSpeed * Time.deltaTime);

        if(isRunning)
        {
            anyStateAnimator.TryPlayAnimation("Run");
        }
        else if (movementInput.y != 0 || movementInput.x != 0)
        {
            anyStateAnimator.TryPlayAnimation("Walk");
        }
        if (characterController.velocity  == Vector3.zero && animationVector == Vector2.zero)
        {
            anyStateAnimator.TryPlayAnimation("Idle");
        }

        anyStateAnimator.Animator.SetFloat("Vertical", animationVector.y);
        anyStateAnimator.Animator.SetFloat("Horizontal", animationVector.x);
    }

    private void Rotate()
    {
        if(!Mouse.current.rightButton.isPressed){
            float mouseX = horizontalMouseInput * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * mouseX);
        }
    }

    private void Run()
    {
        isRunning = !isRunning;

        if(isRunning)
        {
            currentSpeed = runSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }
    }

    private void Jump()
    {
        anyStateAnimator.TryPlayAnimation("Jump");
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
