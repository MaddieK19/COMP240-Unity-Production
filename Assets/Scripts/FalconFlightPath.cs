using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*!
 * FalconFlightPath class
 * This class just moves in a circle to be followed by the falcon
 */
public class FalconFlightPath : MonoBehaviour {
    /// float for the y position of the object 
    public float yPosition;
    /// Vector3 for the objects current position
    Vector3 currentPosition;
    /// float for the timer
    float timeCounter = 0;
    /// floats used for calculating the next position
    float x, y, z;

    /// Use this for initialization
    void Start()
    {

    }

    /// Update is called once per frame
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
