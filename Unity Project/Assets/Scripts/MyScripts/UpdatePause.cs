using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePause : MonoBehaviour {

	public bool gameIsPaused;
	public GameObject pauseMenu;
	


	void Start()
	{
		pauseMenu.SetActive(false);
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (gameIsPaused)
			{
				ContinueGame();
			}
			else
			{
				Pause();
			}
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
