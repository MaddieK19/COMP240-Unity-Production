using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

public class TriggerSerial : ActionNode
{
    public SerialController serialController;

    public override Status Update()
    {
        serialController.SendSerialMessage("p");
        return Status.Success;
    }
}
