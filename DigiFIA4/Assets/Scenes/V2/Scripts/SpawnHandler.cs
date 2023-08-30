using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnHandler : MonoBehaviour
{
    public Transform playerTransform;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        if (TweenData.puzzle1Completed && TweenData.puzzle2Completed == false)
        {
            playerTransform.position = new Vector3(345, 29, 372);
            text.text = "well done adventureure, you have managed to finnish the first puzzle, \n proceed to the desert to continue your adventuer";

        }
        else
        {
            playerTransform.position = new Vector3(250, 15, 250);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(text.text != "" && Input.GetKeyDown(KeyCode.Escape))
        {
            text.text = "";
        }
    }
}
