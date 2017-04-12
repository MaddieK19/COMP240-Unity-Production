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
    //! GameObject for the companion
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
        if (companion.GetComponent<Animation>().clip.name != animationName)
            companion.GetComponent<Animation>().CrossFade(animationName);
                
        return Status.Success;
    }
}
