using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerEnding : MonoBehaviour {

    public Image randomImage;

    public Sprite 
        Cust1,
        Cust2,
        Cust3,
        Cust4,
        Cust5,
        Cust6,
        Cust7,
        Cust8,
        Cust9,
        Cust10,
        Cust11;
    public Sprite[] images;

    void Start()
    {
        images = new Sprite[11];
        images[0] = Cust1;
        images[1] = Cust2;
        images[2] = Cust3;
        images[3] = Cust4;
        images[4] = Cust5;
        images[5] = Cust6;
        images[6] = Cust7;
        images[7] = Cust8;
        images[8] = Cust9;
        images[9] = Cust10;
        images[10] = Cust11;
        
        int num = Random.Range(0, images.Length);
        randomImage.sprite = images[num];
    }
}
