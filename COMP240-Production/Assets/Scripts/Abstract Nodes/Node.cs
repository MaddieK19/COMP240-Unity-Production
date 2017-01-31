using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {
    //! enum of possible states for nodes
    public enum NodeStates { Success, Failure, Running };
    //! The state the Node is currently in
    public NodeStates nodeState = NodeStates.Running;
    
    //! Updates nodeState
    virtual public Node.NodeStates checkNodeState()
    {
        return NodeStates.Running;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
