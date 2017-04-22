using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*!
 *  FalconFlightPath moves in a circular movement to be followed by the companion
 */

public class FalconFlightPath : MonoBehaviour {
    //! float for the y that the flight will be on
    public float yPosition;
    //! Vector3 for where the flight path currently is
    Vector3 currentPosition;
    //! Float for the amount of time passed
    float timeCounter = 0;
    //! floats to calcuate the XYZ of the next position
    float x, y, z;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 previousPosition = currentPosition;
        timeCounter += Time.deltaTime;
        x = Mathf.Cos(timeCounter) * 2;
        z = Mathf.Sin(timeCounter) * 2;
        y = yPosition;
        currentPosition = new Vector3(x, y, z);
        transform.position = currentPosition;
    }
}
