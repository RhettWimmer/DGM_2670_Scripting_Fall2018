using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedPer : MonoBehaviour {

	public Text label;
	public IntData EmployeeMove;
   

	private void Update()
	{
		int number = EmployeeMove.Value; 
      
		label = GetComponent<Text>();
		label.text = number.ToString();
	}
}
