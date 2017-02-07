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

    public bool checkHealth(float currentHealth, float healthThreshold)
    {
        if (currentHealth < healthThreshold)
            return true;
        else
            return false;
    }
    //! checks for player input
    public bool checkForInput()
    {
        // TODO
        return false;
    }

    //! returns bool that indicates whether there's an enemy near the falcon
    public bool checkForPrey()
    {
        // TODO
        return false;
    }

    //! returns bool that indicates whether there's an enemy near the falcon
    public bool checkForPlayer()
    {
        // TODO check if vive controller is near
        return false;
    }
}
