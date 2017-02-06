using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourManager : SelectorNode {
    GameObject companion;
    NodeStates currentBranchState;

	// Use this for initialization
	void Start () {
        childNodes.Add(new DeadBranch());
        //childNodes.Add(new AttackBranch());
        //etc
    }
	
	// Update is called once per frame
	void Update () {
        updateBranches();
    }

    NodeStates updateBranches()
    {
        checkNodeState();
        return NodeStates.Running;
    }
}
