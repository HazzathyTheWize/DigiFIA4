using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRight : Interactable
{
    public bool doorOpen;
    public GameObject door;
    private AudioSource audioSource;
    public Puzzle1Controller controller;
    private bool Entered;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Entered = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {

        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
        audioSource.Play();
        if (Entered)
        {
            controller.correctDoor = doorOpen;
            controller.endPuzzle1();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Entered = true; ;
        } 
    }
    
}
