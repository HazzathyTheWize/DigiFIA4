using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //this is a message displayed to player looking at an interactable
    public string promptMessage;
    
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        // no code written here 
        //template fucntion to be overwtitten by subclasses
    }


}
