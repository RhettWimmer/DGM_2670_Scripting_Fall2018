using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawn : MonoBehaviour
{
    public GameObject MoneyObj;
    public float SpawnTime = 10;
    public Transform[] spawnPoints;

    void Start()
    {
        InvokeRepeating("Spawn", SpawnTime, SpawnTime);
    }

    public void Spawn()
    {
        int SpawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(MoneyObj, spawnPoints[SpawnPointIndex].position, spawnPoints[SpawnPointIndex].rotation);
    }
    
}
