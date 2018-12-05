using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{

	public float Speed = 100;
	public float Cash = 0;

	void Update () {
		transform.Rotate(Vector3.up, Speed * Time.deltaTime);		
	}

	//This Adds Money
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Clerk")
		{	
			Cash++;
			Debug.Log("working" + Cash);
		}
	}
}
