using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverMovement : MonoBehaviour {
    private Animator anim;
    float v;
    float h;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
	// Update is called once per frame
	void Update () {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        anim.SetFloat("Forward", v);
        anim.SetFloat("Backward", h);
	}
}
