using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidbody;


    [SerializeField]
    private float speed;

    [SerializeField]
    private Vector3 direction;

    private float lifeTime = 10;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody.velocity = direction * speed;

        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
