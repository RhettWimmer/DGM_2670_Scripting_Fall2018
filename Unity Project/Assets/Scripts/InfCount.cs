using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InfCount : MonoBehaviour
{

    public UnityEvent OnCount;
    public float Seconds = 1.0f;

    IEnumerator Start()
    {
        while (true)
        {
            OnCount.Invoke();
            yield return new WaitForSeconds(Seconds);
        }
    }
}
