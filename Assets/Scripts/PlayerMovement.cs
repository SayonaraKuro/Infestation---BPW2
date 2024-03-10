using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float horizontalInput;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        
    }

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

        if(horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        } else if(horizontalInput > 0) 
        {
            spriteRenderer.flipX = false;
        }

    }
}
