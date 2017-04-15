using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *  Falcon class for the falcon version of the companion AI
 */
public class Falcon : Companion {
    public int spawnLocation = 10;

    // Use this for initialization
    void Start () {
        Hexgrid terrain = (Hexgrid)FindObjectOfType(typeof(Hexgrid));
        transform.position = new Vector3(terrain.width * spawnLocation, 0, terrain.height* spawnLocation) ;
    }
	
	// Update is called once per frame
	public override void Update () {
        // healthCap keeps the companions health positive
        healthCap();
    }

}
