using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float horizontalInput;
    public SpriteRenderer spriteRenderer;
    public Animator animator;

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        
        player.transform.Translate(Vector2.right * speed * Time.deltaTime * horizontalInput);

        // if(Input.GetKey(KeyCode.A))
        // {
        //     player.transform.Translate(Vector2.left * speed * Time.deltaTime);
        // }

        // if(Input.GetKey(KeyCode.D))
        // {
        //     player.transform.Translate(Vector2.right * speed * Time.deltaTime);
        // }

        // Flips character
        if(horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        } else if(horizontalInput > 0) 
        {
            spriteRenderer.flipX = false;
        }

        if(horizontalInput == 1 || horizontalInput == -1)
        {
            animator.SetBool("IsRunning", true);
        } else {
            animator.SetBool("IsRunning", false);
        }

    }
}
