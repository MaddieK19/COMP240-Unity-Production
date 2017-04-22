using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;
/*!
 *  LeafNode that makes companion stay at a specified position
 */


public class StayOnGameObject : ActionNode
{
    //! GameObject companion will stay on
    public GameObject objectToStayOn;
    //! GameObject for the companion
    public GameObject companion;
    //! float for how long the companion will stay on the objecy
    public float timeToStay = 5.0f;

    public override Status Update()
    {
        if (timeToStay < 1)
            return Status.Success;
        else
        {
            companion.transform.position = objectToStayOn.transform.position;
            timeToStay -= Time.deltaTime;
            return Status.Running;
        }            
    }
}
