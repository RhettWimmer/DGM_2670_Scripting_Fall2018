using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueGame : MonoBehaviour {

    public bool gameIsPaused;
    public GameObject pauseMenu;
   
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
    
}
