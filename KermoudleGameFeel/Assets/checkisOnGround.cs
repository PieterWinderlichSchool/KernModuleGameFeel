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
        Debug.Log(isonGround);
    }
   

   

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("hit");
        isonGround = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 10)
        {
            if (other.gameObject.GetComponent<BoxCollider>().isTrigger != true)
            {
                isonGround = true;
            }
            else
            {
                isonGround = false;
            }
        }
        else
        {
            isonGround = true;
        }
    }
}
