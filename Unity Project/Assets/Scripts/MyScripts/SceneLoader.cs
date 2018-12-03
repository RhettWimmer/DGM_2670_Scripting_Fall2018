using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public int levelToLoad;

    public void LoadLevel(){
        SceneManager.LoadScene(levelToLoad);
    }

}
