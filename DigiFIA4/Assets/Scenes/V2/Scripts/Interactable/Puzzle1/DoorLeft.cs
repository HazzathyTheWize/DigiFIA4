using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLeft : Interactable
{
    public bool doorOpen;
    public GameObject door;
    private AudioSource doorSource;

    // Start is called before the first frame update
    void Start()
    {
        doorSource = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
        doorSource.Play();
    }
}
