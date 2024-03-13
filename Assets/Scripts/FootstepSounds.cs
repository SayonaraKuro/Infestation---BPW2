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

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if(horizontalInput == 1 || horizontalInput == -1)
        {
            groundSound.Play();

            Debug.Log("sound");
        } else {
            groundSound.Stop();
        }
    }

    // private void OnTriggerStay2D(Collider2D other)
    // {
    //     horizontalInput = Input.GetAxisRaw("Horizontal");

    //     if(horizontalInput == 1 || horizontalInput == -1)
    //     {
    //         groundSound.Play();

    //         Debug.Log("sound");
    //     } else {
    //         groundSound.Stop();
    //     }
    // }
}
