using UnityEngine;
using System.Collections;

public class PlayerMoveS : MonoBehaviour {

	[Header("Settings")]
	public float speed = 1f;
	public int animation = 1;

	// COMPONENTS
	private CharacterController cc;
	private Animator anim;

	//============================================
	// FUNCTIONS (UNITY)
	//============================================

	void Awake()
	{
		cc = GetComponent<CharacterController>();
		anim = GetComponent<Animator>();
	}

	void Update()
	{	
		// float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis("Horizontal");
		
		Vector3 forward = transform.forward  * speed * Time.deltaTime;
		Vector3 backwards = -transform.forward * speed * Time.deltaTime;
		Vector3 right = transform.right * speed * Time.deltaTime;
		Vector3 left = -transform.right * speed * Time.deltaTime;

		if(Input.GetKey(KeyCode.W)){
			cc.Move(forward);
			anim.SetFloat ("speed", animation);
		}

		if(Input.GetKey(KeyCode.S)){
			cc.Move(backwards);
			anim.speed = 1f;
		}

		if(Input.GetKey(KeyCode.D)){
			//cc.Move(right);
		    transform.Rotate(0, h , 0);
			anim.speed = 1f;
		}

		if(Input.GetKey(KeyCode.A)){
			transform.Rotate(0, -h , 0);
			//cc.Move(left);
			anim.speed = 1f;
		}
	}
}