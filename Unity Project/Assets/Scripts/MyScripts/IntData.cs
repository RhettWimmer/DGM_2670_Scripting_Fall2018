using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewInt", menuName = "IntData")]
public class IntData : ScriptableObject
{

    public int Value;

/*    public virtual int Value
    {
        get { return IntValue; }
        set { IntValue = value; }
    }*/
}
