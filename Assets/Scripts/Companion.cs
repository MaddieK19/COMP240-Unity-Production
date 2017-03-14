using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Abstract class for Companions in the game to inherit from
 */
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
    //! returns the Companion's position
    public Vector3 getPos()
    {
        return companionObject.transform.position;
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

    // Prevents companion from having negative health
    // Ensures the companion will stay in the DeadState 
    public void healthCap()
    {
        if (getHealth() <= 0)
        {
            setHealth(0);
            isAlive = false;
        }
    }

}
