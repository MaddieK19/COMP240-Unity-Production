using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;
/*
 *  LeafNode that checks to see how far away a specified GameObject is
 */
public class CheckForGameObjects : ActionNode
{
    // GameObject that needs to be checked
    public GameObjectVar objectToCheck;
    // GameObject that runnning the check
    public GameObjectVar companion;
    // Float for how far away objectToCheck is
    private FloatVar distance;
    // Float for the maximum distance away and object can be to return Success
    public FloatVar distanceThreshold;
    // Check to see how far away objectToCheck is and returns 
    // true is distance is within distanceThreshold
    public override Status Update()
    {
        distance = (objectToCheck.Value.transform.position - companion.Value.transform.position).magnitude;

        if (distance > distanceThreshold)
            return Status.Failure;
        else
            return Status.Success;
    }
}
