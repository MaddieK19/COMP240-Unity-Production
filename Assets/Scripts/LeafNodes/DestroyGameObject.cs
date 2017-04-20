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
        UnityEngine.Object.Destroy(objectToDestroy);
        return Status.Success;
    }
}
