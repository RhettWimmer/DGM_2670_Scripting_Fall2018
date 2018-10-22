using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteAfterWait : MonoBehaviour
{
    public int Time = 3;
    
    private void Start()
    {
        StartCoroutine(DestroyText());
    }

        IEnumerator DestroyText(){
        yield return new WaitForSeconds(Time);
        Object.Destroy(gameObject);

    }
}
