using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clerk : MonoBehaviour
{

	public float moveSpeed;
	public float turnSpeed;
	public float jumpHeight;
	
	void Update ()
	{
		var move = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		var turn = Input.GetAxis("Vertical") * Time.deltaTime * turnSpeed;
		var jump = Input.GetAxis("Jump") * Time.deltaTime * jumpHeight;
		
		transform.Translate(move, 0, 0);
		transform.Translate(0,0, turn);
		transform.Translate(0, jump, 0);
	}
}
