
using UnityEngine;

public class IfStatements : MonoBehaviour
{

	public float Speed;
	public bool LightsOn;
	
	// Use this for initialization
	void Start () {
		if (LightsOn && Speed > 4)
		{
			//do work
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
