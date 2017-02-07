using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBranch : SelectorNode
{
    LeafNode companionsHealth, sitOnArm, flying;
    float injuredHealthThreshold = 30;
    // Use this for initialization
    public override void Start()
    {
        childNodes.Add(gameObject.AddComponent<IdleOnArm>());
    }

    // Update is called once per frame
    public override void Update()
    {

    }

    public override NodeStates checkNodeState(ref Companion companion)
    {
        /*for (int i = 0; i < childNodes.Count; i++)
        {
            childNodes[i].checkNodeState(ref companion);
            if (childNodes[i].nodeState == Node.NodeStates.Failure)
                return childNodes[i].nodeState;
        }*/
        return Node.NodeStates.Success;
    }
}
