using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2Controller : MonoBehaviour
{
    public ApiCall apiCaller;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateRiddle()
    {
        StartCoroutine(apiCaller.APICallRiddle());
    }

}
