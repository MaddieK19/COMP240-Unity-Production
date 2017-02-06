using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falcon : Companion {
    GameObject falconBehaviour;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        healthCap();
        changeToIdleAnimation();
       // changeToDeadAnimation();

    }

    // Updates companions current animation to match it's behaviour
    //! Changes companion animation to dead
    void changeToDeadAnimation()
    {
        companionObject.GetComponent<Animation>().wrapMode = WrapMode.Once;
        companionObject.GetComponent<Animation>().CrossFade("FA_Dead");
    }

    void changeToIdleAnimation()
    {
        companionObject.GetComponent<Animation>().wrapMode = WrapMode.Loop;
        companionObject.GetComponent<Animation>().CrossFade("FA_Attack");
    }


}
