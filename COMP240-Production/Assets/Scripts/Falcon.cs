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
        //changeAnimation("FA_Idle");
    }

    //! Updates companions current animation to match it's behaviour
    void changeAnimation(string animationName)
    {
        if (!companionObject.GetComponent<Animation>().IsPlaying(animationName))
        {
            companionObject.GetComponent<Animation>().wrapMode = WrapMode.Once;
            companionObject.GetComponent<Animation>().CrossFade(animationName);
        }
    }

}
