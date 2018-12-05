using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{

	public float Speed = 100;
	public IntData Cash = 0;
	public Button MyButton;
	
	void Update () {
		transform.Rotate(Vector3.up, Speed * Time.deltaTime);		
	}

	//This Adds Money
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Clerk")
		{	
			Cash += 1;
			Debug.Log("working" + Cash);
		}
	}
}
