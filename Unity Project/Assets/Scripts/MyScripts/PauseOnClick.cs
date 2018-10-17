using UnityEngine;
using UnityEngine.UI;  

public class PauseOnClick : MonoBehaviour
{

	void Start(){
	GetComponent<Button>().onClick.AddListener(Pause);
}
	public void Pause()
	{
		Time.timeScale = 0;
		Debug.Log("Is Paused");
	}
}
