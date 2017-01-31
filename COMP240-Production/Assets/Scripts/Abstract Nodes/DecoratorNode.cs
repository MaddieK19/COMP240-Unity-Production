using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorNode : Node {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //! Inverts a NodeState
    /*
		returns a nodeState that is the inverse of the one passed in
	*/
    Node.NodeStates invertState(Node.NodeStates currentState)
    {
        if (currentState == Node.NodeStates.Failure)
        {
            return Node.NodeStates.Success;
        }
        else if (currentState == Node.NodeStates.Success)
        {
            return Node.NodeStates.Failure;
        }
        else
            return Node.NodeStates.Failure;
        // add error
    }

    //! Inverts a bool
    /*
		returns a bool that is the inverse of the one passed in
	*/
    bool invertBool(bool state)
    {
        if (state == false)
        {
            return true;
        }
        else if (state == true)
        {
            return false;
        }
        else
            return false; //TODO Change to error?
    }
}

