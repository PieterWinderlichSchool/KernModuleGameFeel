using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DraggableUI : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{   
    [SerializeField]
    private GameObject elementToSpawn;
    [SerializeField]
    private Camera cam;
    private GameObject activeUIElementInWorld;
    [SerializeField]
    private float draggableUIDistanceToCamera;

    [SerializeField] private AudioSource ASource;
    [SerializeField] private Button button;
    void Start()
    {
        cam = Camera.main;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 mousePosition = Input.mousePosition;
       mousePosition.z = draggableUIDistanceToCamera;
       ASource.Play();
       GameObject draggedUI =  Instantiate(elementToSpawn,cam.ScreenToWorldPoint(mousePosition),transform.rotation) as GameObject;
       draggedUI.GetComponent<DraggableUIBehaviour>().SetOrigin(this.gameObject);
       draggedUI.GetComponent<DraggableUIBehaviour>().Button = this;
       activeUIElementInWorld = draggedUI;
       button.interactable = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        button.interactable = true;
    }

    public void SetElementToSpawn(GameObject newElement)
    {
        elementToSpawn = newElement;
    }

    public void ResetButton()
    {
        button.interactable = true;
    }
}
