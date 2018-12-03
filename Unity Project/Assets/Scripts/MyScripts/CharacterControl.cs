using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
	public float moveSpeed;
/*	public float jumpHeight;	*/

	void Update()
	{
/*		var jump = Input.GetAxis("Jump") * Time.deltaTime * jumpHeight;
		transform.Translate(0, jump, 0);*/


		var move = Time.deltaTime * moveSpeed;
		transform.Translate(move, 0, 0);
	}
}



