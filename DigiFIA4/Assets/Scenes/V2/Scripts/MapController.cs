using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour
{
    public GameObject player;
    public Image mapPointer;

    private Transform playerTransform;

    private float pointerX;
    private float pointerY;

    private float playerX;
    private float playerY;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = player.GetComponent<Transform>();
    }

    private void Update()
    {
        playerX = playerTransform.position.x;
        playerY = playerTransform.position.z;

        
        pointerX = (playerX / 4) + 7.5f;
        pointerY = (playerY / 4) + 7.5f;
    }

    private void FixedUpdate()
    {
        

        mapPointer.rectTransform.anchoredPosition = new Vector2(-pointerX, pointerY);
    }
}
