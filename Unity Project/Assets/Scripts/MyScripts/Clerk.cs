using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clerk : MonoBehaviour
{

	public float moveSpeed;
	public float turnSpeed;
	
	void Update ()
	{
		var move = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		var turn = Input.GetAxis("Vertical") * Time.deltaTime * turnSpeed;
		
		transform.Translate(move, 0, 0);
		transform.Translate(0,0, turn);
	}
}
