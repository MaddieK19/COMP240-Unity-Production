using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

public class ChangeAnimation : ActionNode
{
    public String animationName;
    public bool loopAnimation;
    public GameObject companion;
    public override Status Update()
    {
        if (animationName == null)
        {
            return Status.Failure;
        }
        if (!loopAnimation)
        {
            companion.GetComponent<Animation>().wrapMode = WrapMode.ClampForever;
        }
        else if (loopAnimation)
        {
            companion.GetComponent<Animation>().wrapMode = WrapMode.Loop;
        }

        companion.GetComponent<Animation>().CrossFade(animationName);
        return Status.Success;
    }
}
