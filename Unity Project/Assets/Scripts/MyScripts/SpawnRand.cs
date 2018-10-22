using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRand : MonoBehaviour
{

    public GameObject SpawnOne;
    public GameObject SpawnTwo;
    public GameObject SpawnThree;
    public GameObject Enemy;

    private void Start()
    {
        Instantiate(Enemy);
    }
}
