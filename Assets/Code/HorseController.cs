using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseController : MonoBehaviour
{
   public float speed = 4; 
    public float rotSpeed = 80; 
    public float gravity = 8; 

    Vector3 moveDir = Vector3.zero; // like Vector3 (0,0,0)

    	private CharacterController cc;
    Animator animator;

    void start(){
        cc = GetComponent<CharacterController>();
        animator = GetComponent<Animator> (); //Referenzing 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     if (cc.isGrounded) {
            if(Input.GetKey(KeyCode.W)) {
                 Debug.Log(" w was pressed");
             //   moveDir = new Vector3(0,0,1); //Only move on Z aksis
                moveDir *= speed; 
                 Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            }
     }

    moveDir.y -= gravity * Time.deltaTime;  
cc.Move (moveDir * Time.deltaTime);
    }
}
