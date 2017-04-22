using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using UnityEngine.AI;

/*!
 *  LeafNode that moves the companion towards the goal object
 */

public class MoveTowards : ActionNode
{
    //! NavMeshAgent for the companion
    public NavMeshAgent companionNavMesh;
    //! GameObject for companion 
    public GameObject companion;
    //! GameObject for the goal
    public GameObject goalObject;

    public override Status Update()
    {
        if (Vector3.Distance(companion.transform.position, goalObject.transform.position) < 1)
            return Status.Success;
        else
        {
            companionNavMesh.SetDestination(goalObject.transform.position);
            return Status.Running;
        }
    }
}
