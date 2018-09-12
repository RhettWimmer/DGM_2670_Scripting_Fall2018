using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject{
    
    //public FloatData jumpSpeed;
    public FloatData gravity;

    public FloatData MoveX, MoveY, MoveZ;
    public FloatData Rotx, Roty, Rotz;
	
	
    protected Vector3 moveDirection;
    protected Vector3 rotDirection;


	public void Virtual Invoke(CharacterController controller, Transform transform)
	{
			if (controller.isGrounded)
			{
				Move(transform);
			}
			//moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);

			//moveDirection.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis(("Vertical")));

			//moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			//rotDirection.Set( MoveX.Value, MoveY.Value, MoveZ.Value);
			//rotDirection.Set(Rotx.Value, Roty.Value, Rotz.Value);
			//transform.Rotate(rotDirection);

			//moveDirection = transform.TransformDirection(moveDirection);
			//moveDirection *= speed;
			/*
			  if (Input.GetButton("Jump"))
			 moveDirection.y = jumpSpeed.Value; */
	}

		protected void Move(CharacterController controller){
		moveDirection.y -= gravity.Value * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

		protected void Move(Transform transform)
	{
		rotDirection.Set( MoveX.Value, MoveY.Value, MoveZ.Value);
		rotDirection.Set(Rotx.Value, Roty.Value, Rotz.Value);
		transform.Rotate(rotDirection);	
		moveDirection = transform.TransformDirection(moveDirection);
	}
	
}
