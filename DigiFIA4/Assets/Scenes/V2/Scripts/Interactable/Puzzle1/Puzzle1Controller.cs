using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle1Controller : MonoBehaviour
{
    public bool gameWon;

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
        if (Input.GetKeyDown(KeyCode.Escape)) { escCount++; }

        if(escCount == 0)
        {
            directionText.text = "Welcome stranger... choose wisley, for the path to your future awaits behind one of these doors... [next 'Esc']";
        } else if(escCount == 1)
        {
            directionText.text = "If the wrong door you should choose... [next 'Esc']";
        } else if(escCount == 2)
        {
            directionText.text = "Well, i guess you'll just have to find out... ['Esc']";
        } else
        {
            directionText.text = "";
        }

        

        if (gameWon)
        {
            endPuzzle1();
        }
    }

    public void endPuzzle1()
    {

    }
}
