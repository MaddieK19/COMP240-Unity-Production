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
        try
         {
             serialController.SendSerialMessage("p");
         }
         catch(NullReferenceException)
         {
             Debug.Log("Arduino not connected");
         }
        return Status.Success;



    }
}
