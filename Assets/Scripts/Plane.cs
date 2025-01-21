using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector3 direction;

    private Vector2 smokePosition;

    private bool droppedSupplies;

    public void Setup(Vector3 smokePosition)
    {
        this.smokePosition = new Vector2(smokePosition.x, smokePosition.z);
        direction = (smokePosition - transform.position).normalized;
        direction.y = 0;
        transform.rotation = Quaternion.LookRotation(direction, Vector3.up);

    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //When we are close to the target, we need to drop a supply crate.
        if (Vector2.Distance(new Vector2(transform.position.x, transform.position.z),smokePosition) < 1f)
        {
            //Drop crate
            DropSupplyCrate();
        }
    }

    private void DropSupplyCrate()
    {
        if (!droppedSupplies)
        {
            Instantiate(GameManager.Instance.SupplyCratePrefab, transform.position, Quaternion.identity);
            droppedSupplies = true;
        }
    }
}
