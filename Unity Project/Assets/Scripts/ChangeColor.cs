using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public ColorData SpriteColor;
    
    private SpriteRenderer SRender;

    private void Start()
    {
        SRender = GetComponent<SpriteRenderer>();
        SRender.color = SpriteColor.Value;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<SpriteRenderer>().color =
            SpriteColor.Value;
    }
}
