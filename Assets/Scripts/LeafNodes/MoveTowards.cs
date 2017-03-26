using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using UnityEngine.AI;

public class MoveTowards : ActionNode
{
    public NavMeshAgent companionNavMesh;
    public GameObjectVar companion;
    public GameObjectVar goalObject;

    public override Status Update()
    {
        if (Vector3.Distance(companion.Value.transform.position, goalObject.Value.transform.position) < 1)
        {
            return Status.Success;
        }

        else
        {
            companionNavMesh.transform.position = Vector3.MoveTowards(companionNavMesh.transform.position, goalObject.Value.transform.position, Time.deltaTime * 0.5f);
            return Status.Running;
        }

    }

}
