using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceNode : CompositeNode {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    override public Node.NodeStates checkNodeState()
    {
        for (int i = 0; i < childNodes.Length; i++)
        {
            childNodes[i].checkNodeState();
            if (childNodes[i].nodeState == Node.NodeStates.Failure)
                return childNodes[i].nodeState;
        }
        return Node.NodeStates.Success;
    }
   
}
