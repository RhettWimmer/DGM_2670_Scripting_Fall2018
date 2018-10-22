using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public Text pauseText;
    public Button menuButton;
    public Image menuImage;

    private void Update()
    {
        if (Time.timeScale == 1.0)
        {
            pauseText.GetComponent<Text>().enabled = false;
            menuButton.GetComponent<Button>().enabled = false;
            menuImage.GetComponent<Image>().enabled = false;
        }

        if (Time.timeScale == 0)
        {
            pauseText.GetComponent<Text>().enabled = true;
            menuButton.GetComponent<Button>().enabled = true;
            menuImage.GetComponent<Image>().enabled = true;
        }
    }
}
