using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform lookAtTarget;

    [SerializeField]
    private Transform followTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.LookAt(lookAtTarget);

        Rotate();
    }

    private void Rotate()
    {
        transform.position = followTarget.position;
    }
}
