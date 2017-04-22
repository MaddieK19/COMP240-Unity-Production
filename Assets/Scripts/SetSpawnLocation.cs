using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*!
 *  LeafNode that sets the spawn location of an object
 */

public class SetSpawnLocation : MonoBehaviour {
    //! int for multiplying by to select spawn position
    public int spawnLocation = 10;

    // Use this for initialization
    void Start () {
        Hexgrid terrain = (Hexgrid)FindObjectOfType(typeof(Hexgrid));
        transform.position = new Vector3(terrain.width * spawnLocation, 0, terrain.height * spawnLocation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
