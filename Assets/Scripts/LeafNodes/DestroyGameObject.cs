using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourMachine;
using System;

/*!
 *  LeafNode disables the mesh renderer on objectToDestroy 
 */

public class DestroyGameObject : ActionNode
{
    //! GameObject thats MeshRenderer will be disabled 
    public GameObject objectToDestroy;

    public override Status Update()
    {
        objectToDestroy.GetComponent<MeshRenderer>().enabled = false;
        return Status.Success;
    }
}
