﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using UnityEngine.AI;

public class GoToGameObject : ActionNode {
    public NavMeshAgent companionNavMesh;
    public GameObjectVar companion;
    public GameObjectVar goalObject;

    public override Status Update()
    {
        if (companion.Value.transform.position == goalObject.Value.transform.position)
            return Status.Failure;
        else
        {
            companionNavMesh.SetDestination(goalObject.Value.transform.position);
            return Status.Running;
        }
    }

}
