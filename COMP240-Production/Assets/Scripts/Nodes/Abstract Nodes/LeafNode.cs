using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafNode : Node {
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // Series of functions to check conditions required for different nodes and branches
    //! checks whether the health is above a certain value
    public bool checkHealth(float currentHealth)
    {
        if (currentHealth < 1)
            return false;
        else
            return true;
    }
    //! checks for player input
    bool checkForInput()
    {
        // TODO
        return false;
    }

    //! returns bool that indicates whether there's an enemy near the falcon
    bool checkForPrey()
    {
        // TODO
        return false;
    }
}
