using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill_monster : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        string name_monster = col.attachedRigidbody.name; // lay ra duoc ten cua con quai khi ma minh cham
        
        if (col.gameObject.tag.Equals("ben_trai"))
        {
            Destroy(GameObject.Find("player_0"));
        }

        if (col.gameObject.tag.Equals("ben_tren"))
        {
            Destroy(GameObject.Find(name_monster));
        }
    }
}
