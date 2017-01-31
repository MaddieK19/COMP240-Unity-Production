using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Node : MonoBehaviour {
    public enum NodeStates { Success, Failure, Running };
    public NodeStates nodeState = NodeStates.Running;
    abstract public Node.NodeStates updateChildNodes();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
