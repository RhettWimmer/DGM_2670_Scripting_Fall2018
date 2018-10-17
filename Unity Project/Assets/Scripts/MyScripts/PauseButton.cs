using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{

	void Start()
	{
		Time.timeScale = 1;

	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
			}
			else if (Time.timeScale == 0)
			{
				Time.timeScale = 1;
			}
		}
	}
}