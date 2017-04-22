using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*! 
 * Base class for the companions prey
 */
public class Prey : MonoBehaviour
{
    //! int for the prey's health
    private int health = 100;

    //! Sets health to equal newHealth
    public void setHealth(int newHealth)
    {
        health = newHealth;
    }

    //! Returns health
    public int getHealth()
    {
        return health;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
