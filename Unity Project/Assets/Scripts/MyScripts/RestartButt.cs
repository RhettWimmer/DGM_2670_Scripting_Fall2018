using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButt : MonoBehaviour {

	public int RestartLevel;

	public void LoadLevel(){
		SceneManager.LoadScene(RestartLevel);
		Time.timeScale = 1;
	}	
}
