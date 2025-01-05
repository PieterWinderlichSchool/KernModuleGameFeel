using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableUIBehaviour : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float DistanceToCamera = 0;

    private GameObject originButton;
    private GameObject socket = null;
    public Collider triggerCollider;
    public bool Isinteracting = false;
    public DraggableUI Button;
    void Start()
    {
        cam = Camera.main;

    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (!Input.GetKey(KeyCode.Mouse1) && (Isinteracting == false))
            {
                triggerCollider.isTrigger = true;
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = DistanceToCamera;
                transform.position = cam.ScreenToWorldPoint(mousePosition); 
            }
            else
            {
                triggerCollider.isTrigger = false;
            }
        }
        else
        {
            DragEnded();
        }
    }
    public void SetOrigin(GameObject origin)
    {
        originButton = origin;
    }
    public GameObject GetOrigin()
    {
        return originButton;
    }
    public void SetSocket(GameObject other)
    {
        socket = other;
    }
    public void DragEnded()
    {
        if (socket != null)
        {   
            socket.GetComponent<DraggableUISocket>().SetisFilled(true,this.gameObject);
            socket.GetComponentInChildren<SpriteRenderer>().color = Color.white;
            Destroy(originButton);
        }
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Isinteracting = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        Isinteracting = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "AntiUI")
        {
            Button.ResetButton();
            DragEnded();
           
        }
    }
}
