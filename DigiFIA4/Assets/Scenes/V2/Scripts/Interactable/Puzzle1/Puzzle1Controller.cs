using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle1Controller : MonoBehaviour
{
    public bool correctDoor;
    public TextMeshProUGUI directionText;
    private int escCount;


    // Start is called before the first frame update
    void Start()
    {
        escCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || correctDoor) { escCount++; }



        if (correctDoor) { endPuzzle1(); }

    }

    public void endPuzzle1()
    {
        if (escCount == 0)
        {
            directionText.text = "Well done traveller... you have choosen wisley... [next 'Esc']";
        }
        else if (escCount == 1)
        {
            directionText.text = "I see you saw that it is night, thus no sunlight to magnify... [next 'Esc']";
        }
        else if (escCount == 2)
        {
            directionText.text = "of course you might have t... ['Esc']";
        }
        else
        {
            directionText.text = "";
        }
    }
}
