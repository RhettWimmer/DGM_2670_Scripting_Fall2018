using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detected : MonoBehaviour
{
    public GameObject EndGame;
    

    public void Start()
    {
        EndGame.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Clerk")
        {
            Time.timeScale = 0;
            Debug.Log("End Game");
            EndGame.SetActive(true);
        }
    }
}
