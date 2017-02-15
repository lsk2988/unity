using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps_grass : MonoBehaviour {
    Animator anim;
    AudioSource audio;
    // Use this for initialization
    void Start () {
        anim = GetComponent< Animator> ();
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(anim.GetBool("Jump")== false && anim.velocity.magnitude > 2f && audio.isPlaying == false)
        {
            audio.Play();
        }
	}
}
