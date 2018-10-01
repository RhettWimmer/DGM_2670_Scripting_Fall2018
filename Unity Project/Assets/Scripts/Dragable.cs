using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragable : MonoBehaviour
{

    private Vector3 currentPOS;
    private Vector3 newPOS;
    private Camera cam;
    

    void Start ()
    {
        cam = Camera.main;
        
    }

    private void OnMouseDown()
    {
        currentPOS = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        newPOS = currentPOS + cam.ScreenToWorldPoint(Input.mousePosition);
        newPOS.z = 0;
        transform.position = newPOS;
    }
}
