﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyStateAnimation 
{
    public string AnimationName { get; set; }

    public bool IsPlaying { get; set; }

    public string[] HigherPriority { get; set; }

    public AnyStateAnimation(string animationName, params string[] higherPriority)
    {
        this.AnimationName = animationName;
        this.HigherPriority = higherPriority;
    }
}
