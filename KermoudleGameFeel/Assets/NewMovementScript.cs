using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class NewMovementScript : MonoBehaviour
{

    public CapsuleCollider capsuleCollider;
    public float groundCheckDistance = 0.1f;
    public LayerMask groundLayer;

    void Update()
    {
        if (IsGrounded())
        {
            Debug.Log("Grounded");
        }
        else
        {
            Debug.Log("Not Grounded");
        }
    }

    public float squareSize = 1.0f;

    bool IsGrounded()
    {
        Vector3 center = transform.position;
        float halfSize = squareSize / 2;

        Vector3[] rayOrigins = new Vector3[9]
        {
            center,
            center + new Vector3(halfSize, 0, halfSize),
            center + new Vector3(-halfSize, 0, halfSize),
            center + new Vector3(halfSize, 0, -halfSize),
            center + new Vector3(-halfSize, 0, -halfSize),
            center + new Vector3(halfSize, 0, 0),
            center + new Vector3(-halfSize, 0, 0),
            center + new Vector3(0, 0, halfSize),
            center + new Vector3(0, 0, -halfSize)
        };

        foreach (Vector3 origin in rayOrigins)
        {
            Debug.DrawLine(origin, origin + Vector3.down * groundCheckDistance, Color.red);
            if (Physics.Raycast(origin, Vector3.down, groundCheckDistance, groundLayer))
            {
                return true;
            }
        }

        return false;
    }

    //lijstje van je sprites
    
    


}
   

