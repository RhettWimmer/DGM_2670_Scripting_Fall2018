using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Debugger : ScriptableObject {

    public void Call(string s)
    {
        Debug.Log(s);
    }
}
