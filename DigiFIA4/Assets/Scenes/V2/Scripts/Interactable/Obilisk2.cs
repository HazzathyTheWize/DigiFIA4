using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obilisk2 : Interactable
{
    protected override void Interact()
    {
        SceneManager.LoadScene(2);
    }
}
