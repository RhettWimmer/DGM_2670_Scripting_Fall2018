using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{

	public float Speed = 100;
	public IntData Cash;
	
	void Update () {
		transform.Rotate(Vector3.up, Speed * Time.deltaTime);		
	}

	//This Adds Money
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Clerk")
		{	
			Cash.Value += 1;
			Debug.Log("working" + Cash);
		}
	}
}
