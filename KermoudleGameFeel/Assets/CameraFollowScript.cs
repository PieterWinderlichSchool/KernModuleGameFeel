using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{

    public Camera cam;

    public GameObject objectToFollow;

    public Vector3 offset;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = objectToFollow.transform.position + offset;
    }
}
