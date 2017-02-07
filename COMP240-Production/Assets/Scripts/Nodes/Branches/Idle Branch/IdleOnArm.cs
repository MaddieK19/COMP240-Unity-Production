using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleOnArm : SequenceNode {
    LeafNode companionsHealth, sitOnArm;
    float injuredHealthThreshold = 30;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override NodeStates checkNodeState(ref Companion companion)
    {
        if (companionsHealth.checkHealth(companion.getHealth(), injuredHealthThreshold))
            return NodeStates.Failure;
        else if (sitOnArm.checkForPlayer())
            return NodeStates.Running;
        return NodeStates.Running;
    }
}
