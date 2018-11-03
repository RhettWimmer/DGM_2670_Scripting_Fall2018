using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCustomers : MonoBehaviour
{

    public GameObject Customer;
    public float SpawnTimer = 2f;


    private void Start()
    {
        InvokeRepeating("Spawn", SpawnTimer, SpawnTimer);
    }

    private void Spawn()
    {
        Instantiate(Customer);
    }
}
