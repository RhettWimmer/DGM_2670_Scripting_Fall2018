﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePause : MonoBehaviour {

	public bool gameIsPaused;
	public GameObject pauseMenu;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
				Pause();
			}else{
				ContinueGame();
			}
		}


	public void ContinueGame(){
		pauseMenu.SetActive(false);
		Time.timeScale = 1;
		gameIsPaused = false;

	}

	void Pause(){
		pauseMenu.SetActive(true);
		Time.timeScale = 0;
		gameIsPaused = true;
	}
}
