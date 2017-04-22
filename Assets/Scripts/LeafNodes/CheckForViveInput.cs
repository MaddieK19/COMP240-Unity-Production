using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

public class CheckForViveInput : ActionNode
{
    public SteamVR_TrackedController trackedController;
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