using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourManager : SelectorNode {
    GameObject companion;
    Node.NodeStates currentBranchState;

	// Use this for initialization
	void Start () {
        //childNodes = (new AttackBranch, IdleBranch, FishingBranch, DeadBranch); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    Node.NodeStates updateBranches()
    {
        checkNodeState();
        return Node.NodeStates.Running;
    }
}
