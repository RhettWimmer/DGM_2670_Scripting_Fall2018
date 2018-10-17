using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public Text pauseText;
    public Button menuButton;
    public SpriteRenderer menuImage;

    private void Update()
    {
        if (Time.timeScale == 1)
        {
            pauseText.GetComponent<Text>().enabled = false;
            menuButton.GetComponent<Button>().enabled = false;
            menuImage.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (Time.timeScale == 0)
        {
            pauseText.GetComponent<Text>().enabled = true;
            menuButton.GetComponent<Button>().enabled = true;
            menuImage.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
