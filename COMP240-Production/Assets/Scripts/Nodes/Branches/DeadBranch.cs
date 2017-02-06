using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBranch : SelectorNode {
    LeafNode companionHealth;
    
	// Use this for initialization
	void Start () {
        companionHealth = new LeafNode();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public override NodeStates checkNodeState()
    {
        bool alive = companionHealth.checkHealth();
        if (alive)
            return NodeStates.Failure;
        else
            return NodeStates.Running;
        // The DeadBranch can never succeed as the companion cannot leave the DeadBranch
    }
}
