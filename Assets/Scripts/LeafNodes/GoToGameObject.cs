using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using UnityEngine.AI;
/*!
 *  Leafnode that moves companion navmesh towards a goal object
 */

public class GoToGameObject : ActionNode
{
    //! NavMeshAgent for the companions navmesh
    public NavMeshAgent companionNavMesh;
    //! GameObject for companion
    public GameObject companion;
    //! GameObject for the companion's goal
    public GameObject goalObject;

    public override Status Update()
    {
        if (Vector3.Distance(companion.transform.position, goalObject.transform.position) < 1)
            return Status.Success;
        else
        {
            companionNavMesh.SetDestination(goalObject.transform.position);
            return Status.Success;
        }
    }
}
