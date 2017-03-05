using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;
// Action node for checking for player input
// Checks if player has issued command to companion

public class CheckForInput : ActionNode {
   // String for what key needs to be pressed
    public StringVar key;
    // returns Success Status if the player has pressed the specified key
    public override Status Update()
    {
        if (Input.GetKeyDown(key))
            return Status.Success;
        else
            return Status.Failure;
    }
}
