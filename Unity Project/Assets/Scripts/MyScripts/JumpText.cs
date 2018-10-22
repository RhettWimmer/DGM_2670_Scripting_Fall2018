using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpText : MonoBehaviour
{


    public Image text;
    
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(text);
        }
    }
}
