using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBranch : SelectorNode {
    LeafNode companionHealth;
    
	// Use this for initialization
	public override void Start () {
        companionHealth = new LeafNode();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    //! Checks the companions health to see if it's alive
    public override NodeStates checkNodeState(ref Companion companion)
    {
        bool alive = companionHealth.checkHealth(companion.getHealth());
        if (alive)
            return NodeStates.Failure;
        else
            return NodeStates.Running;
        // The DeadBranch can never succeed as the companion should not be able to leave the DeadBranch
    }
}
