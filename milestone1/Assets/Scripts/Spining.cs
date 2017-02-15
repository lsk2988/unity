using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spining : MonoBehaviour {

	public float spinX;
    public float spinY;
    public float spinZ;


    // Update is called once per frame
    void Update () {
        transform.Rotate(spinX, spinY, spinZ);
	}
}
