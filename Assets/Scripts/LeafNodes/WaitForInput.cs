using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
/* Action node for checking for player input
 * Waits to see if player has issued a spcommand to companion
 */
public class WaitForInput : ActionNode {
    // String of the key that needs to be checked
    public StringVar key;
    // Node returns Running until the player presses the specified key
    public override Status Update()
    {
        if (Input.GetKeyDown(key))
            return Status.Success;
        else
            return Status.Running;
    }
}
