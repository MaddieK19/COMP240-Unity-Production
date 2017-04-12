using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;
/*!
 *  Leafnode that changes the animation of a companion
 */

public class ChangeAnimation : ActionNode
{
    //! String for the name of the new animation
    public String animationName;
    //! Bool for whether the animation should loop or play once
    public bool loopAnimation;
    //! Bool for whether the animation should play after the previous one ended
    public bool waitForAnimationEnd;
    //! GameObject for the companion
    public GameObject companion;

    public override Status Update()
    {
        if (animationName == null)
            return Status.Failure;

        if (!loopAnimation)
            companion.GetComponent<Animation>().wrapMode = WrapMode.ClampForever;

        else if (loopAnimation)
            companion.GetComponent<Animation>().wrapMode = WrapMode.Loop;

        if (!waitForAnimationEnd)
            companion.GetComponent<Animation>().CrossFade(animationName);

        else if (waitForAnimationEnd)
            companion.GetComponent<Animation>().CrossFadeQueued(animationName);

        return Status.Success;
    }
    
}
