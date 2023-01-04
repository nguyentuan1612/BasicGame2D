using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public Animator ani; // nhiệm vụ quản lí toàn bộ animation
    public bool nen_dat;
    
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
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            ani.SetBool("isRunning", true);
            ani.Play("Running");
            transform.Translate(Time.deltaTime * -3,0,0);
            transform.localScale = new Vector3(-1F,1F,1F );
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,Time.deltaTime * 15,0);
        }
        else
        {
            ani.SetBool("isRunning",false);
        }
        
    }
    //tinh toán khi chạm đất mới được nhảy lên tiếp
    private void OnCollisionEnter2D(Collision2D col)//khi đụng tới nền đất thì sẽ chạy hàm này
    {
        throw new NotImplementedException();
    }
}
