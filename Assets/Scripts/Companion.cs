using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*!
 * Abstract class for Companions in the game to inherit from
 */
abstract public class Companion : MonoBehaviour {
    //! float for the companion's health level
    public float health = 100;
    //! Bool for whether the companion is alive
    public bool isAlive = true;

    //! Use this for initialization
    void Start () {
		
	}
	
	//! Update is called once per frame
	public virtual void Update () {
		
	}
 
    //! Returns the Companion's health
    public float getHealth()
    {
        return health;
    }
    //! Sets companions health
    public void setHealth(float newHealth)
    {
        health = newHealth;
    }
}
