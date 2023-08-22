using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Book1 : Interactable
{
    public GameObject bookScreen;
    private bool bookOpen;
    private Transform bookTransform;
    private Vector3 bookPos;
    public Camera mainCam;

    private void Start()
    {
        bookOpen = false;
        bookTransform = bookScreen.GetComponent<Transform>();
        bookPos = bookTransform.position;
        bookScreen.SetActive(false);
       
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            bookScreen.SetActive(false);
            bookOpen = false;
        }

       
    }

    protected override void Interact()
    {
        bookOpen = true;

        if (bookOpen)
        {
            bookScreen.SetActive(true);
            Debug.Log("open");
        }

        

    }
}
