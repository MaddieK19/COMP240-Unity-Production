﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Companion : MonoBehaviour {
    public GameObject companionObject;
    public float health = 100;
    public bool isAlive = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	public virtual void Update () {
		
	}

    // Getter Methods
    //! returns the Companion's X position
    public float getX()
    {
        return companionObject.transform.position.x;
    }
    //! returns the Companion's Y position
    public float getY()
    {
        return companionObject.transform.position.y;
    }
    //! returns the Companion's Z position
    public float getZ()
    {
        return companionObject.transform.position.z;
    }
    //! Returns the Companion's health
    public float getHealth()
    {
        return health;
    }
    // Setter methods
    public void setHealth(float newHealth)
    {
        health = newHealth;
    }

    //! Prevents companion from having negative health
    public void healthCap()
    {
        if (getHealth() <= 0)
        {
            setHealth(0);
            isAlive = false;
        }
    }

}