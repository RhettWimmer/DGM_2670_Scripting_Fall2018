using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FloatInput")]
public class FloatBool : FloatInput {

	
	public override float Value
	{
		get
		{
			if (Input.GetButton(InputType))
			{
				return value;
			}
			else
			{
				return 0;
			}
		}
	}
	
/*
	 if (Input.GetButton("Jump"))
			 moveDirection.y = jumpSpeed.Value;
			 */
}
