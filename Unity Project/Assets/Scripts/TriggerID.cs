using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerID : MonoBehaviour
{

    public NameID ID;
    public UnityEvent OnMatch;

    private void OnTriggerEnter(Collider obj)
    {
        if (ID == obj.GetComponent<ObjectID>().ID)
        {
           OnMatch.Invoke();
            print("Match");   
        }
    }

/*    public void OnTriggerEnter(Collider obj)
    {
        if (tag == obj.tag)
        {
            print(obj.tag);
        }
    }*/
}
