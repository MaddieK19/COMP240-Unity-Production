using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*!
 * Abstract class for Companions in the game to inherit from
 */
abstract public class Companion : MonoBehaviour {
    /// float for companions health
    public float health = 100;
    
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
        return transform.position;
    }
 
    //! Returns a float of companion's health
    public float getHealth()
    {
        return health;
    }
    // Setter methods
    /// sets companions health
    public void setHealth(float newHealth)
    {
        health = newHealth;
    }

    /// Ensures that the companions health doesn't drop below 0
    public void healthCap()
    {
        if (getHealth() <= 0)
            setHealth(0);
    }

}
