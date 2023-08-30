using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Book2 : Interactable
{
    public GameObject bookScreen;
    private bool bookOpen;
    private Transform bookTransform;
    private Vector3 bookPos;
    public Camera mainCam;

    public ApiCall apiCaller;

    private void Start()
    {
        bookOpen = false;
        bookTransform = bookScreen.GetComponent<Transform>();
        bookPos = bookTransform.position;
        bookScreen.SetActive(false);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bookScreen.SetActive(false);
            bookOpen = false;
        }


    }

    protected override void Interact()
    {

        StartCoroutine(apiCaller.APICallRiddle());
        bookOpen = true;

        if (bookOpen)
        {
            bookScreen.SetActive(true);
            Debug.Log("open");
        }



    }
}
