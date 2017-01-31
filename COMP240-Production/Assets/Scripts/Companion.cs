using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Companion : MonoBehaviour {
    public GameObject companionObject;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    float getX()
    {
        return companionObject.transform.position.x;
    }

    float getY()
    {
        return companionObject.transform.position.y;
    }

    float getZ()
    {
        return companionObject.transform.position.z;
    }
}
