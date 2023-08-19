using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obilisk1 : Interactable
{
    public TextMeshProUGUI directionText;

    // Start is called before the first frame update
    void Start()
    {
        directionText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            directionText.text = "";
        }
    }

    protected override void Interact()
    {
        directionText.text = "Head towards the mountain, there you will discover the first of many mysteries... press 'Esc' to dismiss.";
    }
}
