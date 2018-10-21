using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
	public float moveSpeed;
	public float jumpHeight;

	void Update()
	{
		var jump = Input.GetAxis("Jump") * Time.deltaTime * moveSpeed;
		var move = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		
		transform.Translate(move,0,0);
		transform.Translate(0,jump,0);
	}
}


