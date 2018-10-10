using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragable : MonoBehaviour
{

    private Vector3 currentPOS;
    private Vector3 newPOS;
    private Camera cam;

    public bool CanDrag;
    

    void Start ()
    {
        cam = Camera.main;
        
    }

    private IEnumerator OnMouseDown()
    {
        currentPOS = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
        yield return new WaitForFixedUpdate();
        CanDrag = true;
        print("Down");
        while (CanDrag)
        {
            yield return new WaitForFixedUpdate();
            newPOS = currentPOS + cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = newPOS;
        }
    }

    private void OnMouseUp()
    {
        CanDrag = false;
        print("Up");
    }
}
