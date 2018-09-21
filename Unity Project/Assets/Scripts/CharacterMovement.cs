using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour {
	
	//public float speed = 6.0F;
	/*public FloatData jumpSpeed;
	public FloatData gravity;

	public FloatData MoveX, MoveY, MoveZ;
	public FloatData Rotx, Roty, Rotz;
	
	
	private Vector3 moveDirection;
	private Vector3 rotDirection; */
	private CharacterController controller;
	public MovePattern Pattern;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}
	
	void Update() {
		
		Pattern.Invoke(controller, transform);
		
		
	/*	
		if (controller.isGrounded) {
			
			moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
			
			//moveDirection.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis(("Vertical")));
			
			//moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			rotDirection.Set( MoveX.Value, MoveY.Value, MoveZ.Value);
			rotDirection.Set(Rotx.Value, Roty.Value, Rotz.Value);
			transform.Rotate(rotDirection);
			
			moveDirection = transform.TransformDirection(moveDirection);
			//moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed.Value;
            
		}
		moveDirection.y -= gravity.Value * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
		*/
	}
}