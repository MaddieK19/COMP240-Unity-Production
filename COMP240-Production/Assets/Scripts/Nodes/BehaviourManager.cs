using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourManager : SelectorNode {
    NodeStates currentBranchState;
    public Companion companion;

    // Use this for initialization
    void Start () {
        //DeadBranch dead = gameObject.AddComponent<DeadBranch>();
        childNodes.Add(gameObject.AddComponent<DeadBranch>());
        //childNodes.Add(new AttackBranch());
        //etc
    }
	
	// Update is called once per frame
	void Update () {
        companion.setHealth(companion.getHealth() - 1);
        updateBranches();
    }

    NodeStates updateBranches()
    {
        checkNodeState(ref companion);
        return NodeStates.Running;
    }
}
