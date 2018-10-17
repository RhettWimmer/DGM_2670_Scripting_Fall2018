using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayOnClick : MonoBehaviour {

	void Start(){
		GetComponent<Button>().onClick.AddListener(Pause);
	}
	public void Pause()
	{
		Time.timeScale = 1;
		Debug.Log("Playing");
	}
}
