using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunCountDown : MonoBehaviour {

	private Text label; 

	IEnumerator Start () 
	{
		label = GetComponent<Text>();

		int number = 100;

		while (number > 0 )
		{
			yield return new WaitForSeconds(0.1f);
			label.text = number.ToString();
			number--;
		}
		
/*		label.text = "3";	
		yield return new WaitForSeconds(1);
		label.text = "2";
		yield return new WaitForSeconds(1);
		label.text = "1";*/
		
		yield return new WaitForSeconds(1);
		label.text = "GO!";
	}
}
