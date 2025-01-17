using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private Vector3 rotationDirection;

    [SerializeField]
    private float movementSpeed;

    [SerializeField]
    private Vector3 movementDirection;

    [SerializeField]
    private float distance;

    private float startY;

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Move();
    }

    private void Rotate()
    {
        transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
    }

    private void Move()
    {
        transform.Translate(movementDirection * movementSpeed * Time.deltaTime, Space.World);
    
        if (Mathf.Abs(transform.position.y - startY) >= distance)//When we have reached our goal
        {
            startY = transform.position.y; //Log new start postion
            movementDirection *= -1; //reverse direction
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager.MyInstance.Score++;
            Debug.Log(UIManager.MyInstance.Score);
            Destroy(gameObject);
        }
    }
}
