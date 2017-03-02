using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

public class CheckHealth : ActionNode
{
    //public GameObjectVar companion;
    public Companion companion;
    public FloatVar maxhealthThreshold;
    public FloatVar minhealthThreshold;
    public override Status Update()
    {
        if (companion.getHealth() < maxhealthThreshold && companion.getHealth() > minhealthThreshold)
        {
            return Status.Success;
        }
        else
            return Status.Failure;
    }
}
