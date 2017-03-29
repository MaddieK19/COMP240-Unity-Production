using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 * Base class for the companions prey
 */
public class Prey : MonoBehaviour
{
    GameObject falcon;
    int health = 100;

    // Use this for initialization
    void Start()
    {
        falcon = GameObject.FindGameObjectWithTag("Predator");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Predator")
        {
            transform.parent = falcon.transform;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Predator")
        {
            transform.parent = null;
        }
    }
}
