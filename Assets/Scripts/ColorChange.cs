using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spr;

    public Color[] col;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        col = new Color[3];

        col[0] = Color.red;
        col[1] = Color.green;
        col[2] = Color.blue;

    }
}
