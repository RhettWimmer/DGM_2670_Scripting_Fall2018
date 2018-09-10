using UnityEngine;

[CreateAssetMenu(fileName =  "NewFloat", menuName = "FloatData")]
public class FloatData : ScriptableObject
{
    public float value;
    
    public virtual float Value
    {
        get { return value;}
        //set { Value = value; }
    }

}
