using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

public class DestroyGameObject : ActionNode
{
    public GameObject objectToDestroy;
    public override Status Update()
    {
        objectToDestroy.GetComponent<MeshRenderer>().enabled = false;
        return Status.Success;
    }
}
