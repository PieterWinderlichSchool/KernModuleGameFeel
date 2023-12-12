using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnModel : MonoBehaviour
{

 
    public float movementduration;
    private float elapsedTime;
    private bool movingForward = true;

    private void LateUpdate()
    {
        

        if (Input.GetKeyDown(KeyCode.D))
        {
            movingForward = true;
            elapsedTime = 0;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            movingForward = false;
            elapsedTime = 0;
        }
        if (movingForward)
        {
            elapsedTime += Time.deltaTime;
            float percentageComplete = elapsedTime / movementduration;
            transform.localRotation = Quaternion.Lerp(transform.localRotation,Quaternion.Euler(0,90,0), percentageComplete);
        }
        else if(!movingForward)
        {
            elapsedTime += Time.deltaTime;
            float percentageComplete = elapsedTime / movementduration;
            transform.localRotation = Quaternion.Lerp(transform.localRotation,Quaternion.Euler(0,270,0), percentageComplete);
        }
        
    }
    
    
}
