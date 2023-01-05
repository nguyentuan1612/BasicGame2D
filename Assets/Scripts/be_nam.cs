using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class be_nam : MonoBehaviour
{
    public bool gioiHan = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gioiHan == true)
        {
            transform.Translate(-Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "gioi_han")
        {
            gioiHan = false;
        }
    }
}
