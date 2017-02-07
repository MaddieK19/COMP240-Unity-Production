using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositeNode : Node {

    //! Vector of child nodes
    public List<Node> childNodes = new List<Node>();
    // Time since game started runngingz
    public Time timer;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	public override void Update () {
        // TODO: Will only update node every so many frames
    }
    //! Updates the Node
    public override Node.NodeStates checkNodeState(ref Companion companion)
    {
        Debug.Log("called composite update");
        for (int i = 0; i < childNodes.Count; i++)
        {
            childNodes[i].checkNodeState(ref companion);
        }
        return Node.NodeStates.Running;
    }

    //! adds a node to the childNodes vector
    void addChild()
    {
        childNodes.Add(new Node());
    }

    //! Checks to see if childNodes is empty
    bool nodeHasChild()
    {
        if (childNodes.Count < 1)
            return false;
        else
            return true;
    }
}