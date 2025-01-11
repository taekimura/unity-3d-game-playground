using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngineInternal;

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

    private bool canShoot = true;

    [SerializeField]
    private float shootDelay;

    #endregion


    private void Awake()
    {
        currentSpeed = walkSpeed;
        actions = new PlayerActions();
        actions.Controls.Move.performed += cxt => movementInput = cxt.ReadValue<Vector2>();
        actions.Controls.MouseMovement.performed += cxt => horizontalMouseInput = cxt.ReadValue<float>();
        actions.Controls.Run.performed += cxt => Run();
        actions.Controls.Jump.performed += cxt => Jump();
        actions.Controls.Wave.performed += cxt => Wave();
        actions.Controls.Aim.performed += cxt => Aim();
    }

    // Start is called before the first frame update
    private void Start()
    {
        AnyStateAnimation idle = new AnyStateAnimation("Idle",false,"Jump");
        AnyStateAnimation walk = new AnyStateAnimation("Walk", false, "Jump");
        AnyStateAnimation run = new AnyStateAnimation("Run", false, "Jump");
        AnyStateAnimation jump = new AnyStateAnimation("Jump", false);
        AnyStateAnimation wave = new AnyStateAnimation("Wave",true);
        AnyStateAnimation aim = new AnyStateAnimation("Aim", true);
        AnyStateAnimation shoot = new AnyStateAnimation("Shoot", true);


        anyStateAnimator.AddAnimations(idle, walk,run, jump, wave,aim,shoot);
    }

    // Update is called once per frame
    private void Update()
    {
        Movement();
        Rotate();
        Shoot();
    }

    private void Movement()
    {
        Vector3 movement = transform.right * movementInput.x + transform.forward * movementInput.y;

        animationVector = Vector2.MoveTowards(animationVector, movementInput, animationSmoothTime * Time.deltaTime);

        characterController.Move(movement * currentSpeed * Time.deltaTime);

        if (isRunning)
        {
            anyStateAnimator.TryPlayAnimation("Run");
        }
        else if (movementInput.y != 0 || movementInput.x != 0)
        {
            anyStateAnimator.TryPlayAnimation("Walk");
        }
        if (characterController.velocity==Vector3.zero && animationVector == Vector2.zero)
        {
            anyStateAnimator.TryPlayAnimation("Idle");
        }
        anyStateAnimator.Animator.SetFloat("Vertical", animationVector.y);
        anyStateAnimator.Animator.SetFloat("Horizontal", animationVector.x);
    }

    private void Rotate()
    {
        if (!Mouse.current.rightButton.isPressed)
        {
            float mouseX = horizontalMouseInput * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * mouseX);
        }
    
    }

    private void Run()
    {
        isRunning = !isRunning;

        if (isRunning)
        {
            //We need to run
            currentSpeed = runSpeed;
        }
        else
        {
            //we need to stop running
            currentSpeed = walkSpeed;
        }
    }

    private void Jump()
    {
        anyStateAnimator.TryPlayAnimation("Jump");
    }

    private void Wave()
    {
        anyStateAnimator.TryPlayAnimation("Wave");
    }

    private void Aim()
    {
        if (!anyStateAnimator.IsAnimationActive("Aim"))
        {
            anyStateAnimator.TryPlayAnimation("Aim");
        }
        else
        {
            anyStateAnimator.OnAnimationDone("Aim");
        }
    }

    private void Shoot()
    {
        if (canShoot && Mouse.current.leftButton.IsPressed())
        {
            if (anyStateAnimator.IsAnimationActive("Aim"))
            {
                canShoot = false;
                anyStateAnimator.TryPlayAnimation("Shoot");
                StartCoroutine(ShootCooldown());
            }
        }
    }

    private IEnumerator ShootCooldown()
    {
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
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
