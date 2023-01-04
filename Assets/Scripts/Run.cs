using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public Animator ani; // nhiệm vụ quản lí toàn bộ animation
    public bool nen_dat;
    public bool isRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
        // lấy toàn bộ animation của thằng animator của thằng unity
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ani.SetBool("isRunning", true);
            ani.Play("Running");
            transform.Translate(Time.deltaTime * 3,0,0);
            transform.localScale = new Vector3(1F,1F,1F );
            isRight = true;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            ani.SetBool("isRunning", true);
            ani.Play("Running");
            transform.Translate(Time.deltaTime * -3,0,0);
            transform.localScale = new Vector3(-1F,1F,1F );
            isRight = false;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            if (nen_dat == true)
            {
                if (isRight == true)
                {
                    transform.Translate(Time.deltaTime * 5,2.5F,0);

                }
                else
                {
                    transform.Translate(- Time.deltaTime * 5,2.5F,0);
                }
                nen_dat = false;
            }
        }
        else
        {
            ani.SetBool("isRunning",false);
        }
        
    }
    //tinh toán khi chạm đất mới được nhảy lên tiếp
    private void OnCollisionEnter2D(Collision2D col)//khi đụng tới nền đất thì sẽ chạy hàm này
    {
        if (col.gameObject.tag == "nen_dat")
        {
            nen_dat = true;
            Console.WriteLine(nen_dat);
        }
       
        {
            
        }
    }
}
