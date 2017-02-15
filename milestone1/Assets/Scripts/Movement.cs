using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class Movement : MonoBehaviour {
    Animator anim;
    bool isWalking = false;
    const float WALK_SPEED = .25f;
     void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //turning
        //jumping
        //move
        Walking();
        Turning();
        Move();
        Jump();
    }
    void Turning()
    {
        anim.SetFloat("Turn", Input.GetAxis("Horizontal"));
    }
    void Walking()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isWalking = !isWalking;
            anim.SetBool("Walk", isWalking);
        }     
    }


    void Move()
    {
        if (anim.GetBool("Walk"))
        {
            //for MoveY
            /*  if(Input.GetAxis("MoveZ") < 0)
                   anim.SetFloat("MoveZ", -.25f);//default speed
              else if(Input.GetAxis("MoveZ") > 0)
                   anim.SetFloat("MoveZ", .25f);
              else
                  anim.SetFloat("MoveZ", 0);
              //for MoveX
              if (Input.GetAxis("MoveX") < 0)
                  anim.SetFloat("MoveX", -.25f);//default speed
              else if (Input.GetAxis("MoveX") > 0)
                  anim.SetFloat("MoveX", .25f);
              else
                  anim.SetFloat("MoveX", 0);*/
            anim.SetFloat("MoveZ", Mathf.Clamp(Input.GetAxis("MoveZ"), -WALK_SPEED, WALK_SPEED));
            anim.SetFloat("MoveX", Mathf.Clamp(Input.GetAxis("MoveX"), -WALK_SPEED, WALK_SPEED));

        }
        else
        {
            anim.SetFloat("MoveZ", Input.GetAxis("MoveZ"));
            anim.SetFloat("MoveX", Input.GetAxis("MoveX"));
        }
        
    }

  void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            anim.SetTrigger("Jump");
    }
}
