using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositeNode : Node {

    //! Vector of child nodes
    Node[] childNodes;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override Node.NodeStates updateChildNodes()
    {
        Debug.Log("called composite update");
        for (int i = 0; i < childNodes.Length; i++)
        {
            childNodes[i].updateChildNodes();
        }
        return Node.NodeStates.Running;
    }

    //! adds a node to the childNodes vector
    void addChild()
    {
        childNodes = new Node[childNodes.Length + 1];
    }
}