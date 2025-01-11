using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class AnyStateAnimator : MonoBehaviour
{
    private Animator animator;

    private Dictionary<string, AnyStateAnimation> anyStateAnimations = new Dictionary<string, AnyStateAnimation>();

    public Animator Animator { get => animator; private set => animator = value; }

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animate();
    }

    public void AddAnimation(params AnyStateAnimation[] animations)
    {
        for (int i = 0; i < animations.Length; i++)
        {
            this.anyStateAnimations.Add(animations[i].AnimationName, animations[i]);
        }
    }

    public void TryPlayAnimation(string animationName)
    {

        bool startAnimation = true;

        if (anyStateAnimations[animationName].HigherPriority == null){
            StartAnimation();
        }
        else
        {
            foreach(string animName in anyStateAnimations[animationName].HigherPriority)
            {
                if(anyStateAnimations[animName].IsPlaying == true){
                    startAnimation = false;
                    break;
                }
            }
            if (startAnimation)
            {
                StartAnimation();
            }
        }

        void StartAnimation ()
        {
            foreach(string animName in anyStateAnimations.Keys.ToList())
        {
            anyStateAnimations[animName].IsPlaying = false;
        }
        anyStateAnimations[animationName].IsPlaying = true;
        }
    }

    public void onAnimationDone(string animationName)
    {
        anyStateAnimations[animationName].IsPlaying = false;
    }

    private void Animate()
    {
        foreach (string key in anyStateAnimations.Keys)
        {
            Animator.SetBool(key, anyStateAnimations[key].IsPlaying);
        }
    }
}
