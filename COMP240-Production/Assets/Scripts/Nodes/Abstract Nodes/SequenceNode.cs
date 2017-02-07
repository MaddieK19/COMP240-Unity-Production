using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceNode : CompositeNode {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // checkNodeState();
    }

    //! Checks the state of all child nodes and sets it owns NodeState depending on that
    override public Node.NodeStates checkNodeState(ref Companion companion)
    {
        for (int i = 0; i < childNodes.Count; i++)
        {
            childNodes[i].checkNodeState(ref companion);
            if (childNodes[i].nodeState == Node.NodeStates.Failure)
                return childNodes[i].nodeState;
        }
        return NodeStates.Success;
    }
   
}
