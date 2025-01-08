using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class AnyStateAnimator : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryPlayAnimation(string animationName)
    {
        animator.SetBool(animationName, true);
    }

    public void onAnimationDone(string animationName)
    {
        animator.SetBool(animationName, false);
    }
}
