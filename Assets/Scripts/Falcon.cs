﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falcon : Companion {
    GameObject falconBehaviour;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	public override void Update () {
        healthCap();
    }

}