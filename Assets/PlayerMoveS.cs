using UnityEngine;
using System.Collections;

public class PlayerMoveS : MonoBehaviour {

	[Header("Settings")]
	public float speed = 1f;
	int currentNumber = 0;
	private CharacterController cc;
	private Animator anim;
	bool horseiswalking;


	void Awake()
	{
		cc = GetComponent<CharacterController>();
		anim = GetComponent<Animator>();
	}

	void Update()
	{	
		// float v = Input.GetAxis("Vertical");
		//float h = Input.GetAxis("Horizontal")
	Vector3 forward = transform.forward  * speed * Time.deltaTime;
	Vector3 backwards = -transform.forward * speed * Time.deltaTime;

	//	Vector3 right = transform.right * speed * Time.deltaTime;
	//	Vector3 left = -transform.right * speed * Time.deltaTime;

	if(cc.isGrounded){
		if(Input.GetKey(KeyCode.W)){
			cc.Move(forward);
			horsewalking();
			horseiswalking = true; 
			if(Input.GetKey(KeyCode.W) && horseiswalking == true ){
				cc.Move(forward);
				horsetroting();
			}
		} 
	}
		if(Input.GetKey(KeyCode.S)){
			cc.Move(backwards);
		}

		if(Input.GetKey(KeyCode.D)){
		    transform.Rotate(0, 1 , 0);
		}

		if(Input.GetKey(KeyCode.A)){
			transform.Rotate(0, -1 , 0);	
		}
	}

	void KeyPressed(int input) {
		currentNumber = currentNumber + input;
	//	Debug.Log(currentNumber);
	}

	void horsewalking (){

		anim.SetFloat ("gear", 1);
		speed = 2f; 
	}

	
	void horsetroting (){
		anim.SetFloat ("gear", 2);
		speed = 5f; 

	}

	
	void horsegalopping (){
	anim.SetFloat ("gear", 3);
	speed = 10f; 
	}

	void horsejumping (){
		//todo
	}
}