using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region COMPONENTS
    [SerializeField]
    private CharacterController characterController;

    private PlayerActions actions;

    [SerializeField]
    private Animator animator;

    #endregion

    #region INPUT
    private Vector2 movementInput;

    #endregion

    #region VALUES

    [SerializeField]
    private float movementSpeed;

    #endregion


    // Start is called before the first frame update
    private void Awake()
    {
        actions = new PlayerActions();
        actions.Controls.Move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        actions.Controls.Idle.performed += ctx => Idle();
        actions.Controls.Battle.performed += ctx => Battle();
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        // move a character based on input 
        Vector3 movement = transform.right * movementInput.x + transform.forward * movementInput.y;

        characterController.Move(movement * movementSpeed * Time.deltaTime);
    }

    private void Idle()
    {
        animator.SetBool("Idle", true);
        animator.SetBool("Battle", false);
    }

    private void Battle()
    {
        animator.SetBool("Idle", false);
        animator.SetBool("Battle", true);
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
