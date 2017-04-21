using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *  Falcon class for the falcon version of the companion AI
 */
public class Falcon : Companion {
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	public override void Update () {
        // healthCap keeps the companions health positive
        healthCap();
    }

}
