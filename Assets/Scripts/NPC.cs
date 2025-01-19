﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{


    [SerializeField]
    private Animator animator;

    [SerializeField]
    private CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canvasGroup.alpha = 1;
            animator.Play("Wave_NPC");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canvasGroup.alpha = 0;
            animator.Play("Wave_NPC");
        }
    }
}
