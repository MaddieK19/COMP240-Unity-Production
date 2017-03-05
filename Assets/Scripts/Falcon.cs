using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *  Falcon class for the falcon version of the companion AI
 */
public class Falcon : Companion {
    // SerialController to send data to Arduino
    public SerialController serialController;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	public override void Update () {
        // healthCap keeps the companions health positive
        healthCap();
    }

    // Checks for collision
    // If colliding with the Player data is sent to the Arduino
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
            serialController.SendSerialMessage("p");
    }

}
