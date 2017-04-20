using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

public class StayOnGameObject : ActionNode
{
    public GameObject objectToStayOn;
    public GameObject companion;
    public float timeToStay = 5.0f;

    public override Status Update()
    {
        if (timeToStay < 1)
        {
            return Status.Success;
        }
        else
        {
            companion.transform.position = objectToStayOn.transform.position;
            timeToStay -= Time.deltaTime;
            return Status.Running;
        }            
    }
}
