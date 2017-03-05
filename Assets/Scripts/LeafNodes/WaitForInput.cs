using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;

public class WaitForInput : ActionNode {

    // Action node for checking for player input
    // Checks if player has issued command to companion

    public StringVar key;
    public override Status Update()
    {
        if (Input.GetKeyDown(key))
            return Status.Success;
        else
            return Status.Running;
    }
}
