using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningRoomController : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TweenData.puzzle1Completed = true;
            SceneManager.LoadScene(1);
        }
    }
}
