using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseCount : MonoBehaviour {
   
    public Text label;
    public IntData Cash;
   

    private void Update()
    {
        int number = Cash.Value; 
      
        label = GetComponent<Text>();
        label.text = number.ToString();
    }

}
