using System.Collections;
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
        //changeAnimation("FA_Idle");
        if (getHealth() < 1)
        {
            changeAnimation("FA_Dead");
        }
    }

    //! Updates companions current animation to match it's behaviour
    void changeAnimation(string animationName)
    {
        if (!companionObject.GetComponent<Animation>().IsPlaying(animationName))
        {
            // TODO : stop dead/landing animations from looping
            companionObject.GetComponent<Animation>().wrapMode = WrapMode.Once;
            companionObject.GetComponent<Animation>().CrossFade(animationName);
        }
    }

}
