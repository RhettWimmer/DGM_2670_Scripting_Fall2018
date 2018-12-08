using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clerk : MonoBehaviour
{

	public IntData EmployeeMove;
/*	public float moveSpeed;*/
	public IntData turnSpeed;
	
	
	void Update ()
	{
		var move = Input.GetAxis("Horizontal") * Time.deltaTime * EmployeeMove.Value;
		var turn = Input.GetAxis("Vertical") * Time.deltaTime * turnSpeed.Value;
		
		transform.Translate(move, 0, 0);
		transform.Translate(0,0, turn);

		if (EmployeeMove.Value <= 1)
		{
			EmployeeMove.Value = 5;
		}
	}
}
