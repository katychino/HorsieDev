using UnityEngine;
using System.Collections;

public class PlayerMoveS : MonoBehaviour {

	[Header("Settings")]
	public float speed = 10f;

	// COMPONENTS
	private CharacterController cc;

	//============================================
	// FUNCTIONS (UNITY)
	//============================================

	void Awake()
	{
		cc = GetComponent<CharacterController>();
	}

	void Update()
	{	
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis("Horizontal");
		
	
		Vector3 forward = transform.forward * v * speed * Time.deltaTime;
		Vector3 right = transform.right * h * speed * Time.deltaTime;

	
		cc.Move(forward + right);
	}
    }