using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSounds : MonoBehaviour
{
    public GameObject player;
    public float horizontalInput;
    public GameObject ground;
    public AudioSource groundSound;
    public AudioSource woodSound;
    public bool playingSound = false;
    private bool onTheTrigger = false;

    void Start()
    {
        groundSound.playOnAwake = false;
        groundSound.Pause();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        // Debug.Log(horizontalInput);

        // if(playingSound == true)
        // {
        //     groundSound.UnPause();
        // } else {
        //     groundSound.Pause();
        // }

        if(horizontalInput == 1 && onTheTrigger == true || horizontalInput == -1 && onTheTrigger == true)
        {
            groundSound.UnPause();
        }

        if(onTheTrigger == false)
        {
            groundSound.Pause();
        }
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // if(horizontalInput == 1 || horizontalInput == -1)
        // {
        //     // groundSound.Play();

        //     playingSound = true;

        //     Debug.Log("PLAY");
        // }

        // if(horizontalInput == 0)
        // {
        //     groundSound.Stop();

        //     playingSound = false;
        // }
        
        // Debug.Log("blabla");
        onTheTrigger = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        groundSound.Pause();
    }
}
