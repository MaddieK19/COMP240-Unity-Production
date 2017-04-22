using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;
/*!
 * LeafNode that checks for Vive controller input and returns Success if buttonToCheck is pressed
 */
public class CheckForViveInput : ActionNode
{
    //! TrackedController to get input from
    public SteamVR_TrackedController trackedController;
    //! String for which button needs to be checked
    public String buttonToCheck;

    public override Status Update()
    {
        if (trackedController.triggerPressed && buttonToCheck == "trigger")
            return Status.Success;
        if (trackedController.gripped && buttonToCheck == "grip")
            return Status.Success;
        else
            return Status.Failure;
    }
}