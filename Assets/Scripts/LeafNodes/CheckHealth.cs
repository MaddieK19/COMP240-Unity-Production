using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;
/*
 * LeafNode that checks that the Companions health is withing a specified range
 */
public class CheckHealth : ActionNode
{
    // Companion thats health is being checked
    public Companion companion;
    // Float for the largest the health can be to return Success
    public FloatVar maxhealthThreshold;
    // Float for the smallest the health can be to return Success
    public FloatVar minhealthThreshold;
    // Checks companion's health against the thresholds
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
