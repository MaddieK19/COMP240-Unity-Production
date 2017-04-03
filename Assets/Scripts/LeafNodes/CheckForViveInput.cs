using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

public class CheckForViveInput : ActionNode
{
    public SteamVR_TrackedController trackedController;


    public override Status Update()
    {
        if (trackedController.triggerPressed)
            return Status.Success;
        else
            return Status.Failure;
    }
}
