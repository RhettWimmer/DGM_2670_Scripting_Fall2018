using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detected : MonoBehaviour
{

    public Text EndGameText;
    public Button RestartButton;

    public void Start()
    {
        EndGameText.GetComponent<Text>().enabled = false;
        RestartButton.GetComponent<Button>().enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Clerk")
        {
            Time.timeScale = 0;
            EndGameText.GetComponent<Text>().enabled = true;
            RestartButton.GetComponent<Button>().enabled = true;
        }
    }
}
