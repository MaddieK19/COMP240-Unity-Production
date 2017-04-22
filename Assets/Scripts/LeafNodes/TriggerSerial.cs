using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

 /*!
 * LeafNode that sends a serial message to the Arduino 
 */


public class TriggerSerial : ActionNode
{
    //! SerialController to send serial message with
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
