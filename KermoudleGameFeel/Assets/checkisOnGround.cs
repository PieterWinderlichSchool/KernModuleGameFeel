using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkisOnGround : MonoBehaviour
{

    public bool isonGround = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
   

   

    private void OnTriggerExit(Collider other)
    {
        isonGround = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 10)
        {
            if (other.gameObject.GetComponent<BoxCollider>().isTrigger != true)
            {
                isonGround = true;
                Debug.Log("hit");
            }
            //else
           // {
             //   isonGround = false;
            //    Debug.Log("hit2");
           // }
        }
        else
        {
            isonGround = true;
        }
    }
}
