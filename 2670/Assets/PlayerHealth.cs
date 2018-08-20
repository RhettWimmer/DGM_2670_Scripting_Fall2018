using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{


	public FloatData Health;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Health.Value > 0)
		{
			//live
		}
		else
		{
			//die
		}
	}
}
