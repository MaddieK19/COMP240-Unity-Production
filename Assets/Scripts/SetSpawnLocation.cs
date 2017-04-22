using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpawnLocation : MonoBehaviour {
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
