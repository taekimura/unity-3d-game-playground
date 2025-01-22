using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupplyCreate : MonoBehaviour
{
    [SerializeField]
    private float distance;

    [SerializeField]
    private LayerMask layerMask;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private Rigidbody myRigidbody;

    [SerializeField]
    private float openForce;


    private bool unfolded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit,distance, layerMask))
        {
            if (!unfolded)
            {
                animator.Play("Unfold");
                unfolded = true;
                myRigidbody.AddForce(Vector3.up * openForce, ForceMode.Impulse);
                myRigidbody.drag = 5;
                
            }
            else if (hit.distance <= 2.5f)
            {
                animator.Play("Fold");
            }         
            
        }
    }
}
