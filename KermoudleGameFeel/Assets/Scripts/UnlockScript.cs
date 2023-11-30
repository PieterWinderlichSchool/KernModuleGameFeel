using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockScript : MonoBehaviour
{
    [SerializeField]
    private GameObject SocketOBJ;

    public Vector3 positiontoMoveTo;
    public DraggableUISocket Socket;

    public float movementduration;
    private float elapsedTime;

    private bool isUnlocked = false;
    // Start is called before the first frame update
    void Start()
    {
        Socket = SocketOBJ.GetComponent<DraggableUISocket>();
        Socket.activateSocket += UnlockDoor;
    }
    private void UnlockDoor()
    {
        isUnlocked = true;
    }

    private void Update()
    {
        if (isUnlocked)
        {
            elapsedTime += Time.deltaTime;
            float percentageComplete = elapsedTime / movementduration;
            
            transform.localPosition = Vector3.Lerp(transform.localPosition,positiontoMoveTo, percentageComplete);
        }
    }
}
