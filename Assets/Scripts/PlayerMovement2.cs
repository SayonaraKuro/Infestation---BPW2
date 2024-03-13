using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public Vector2 movement = new Vector2();
    Rigidbody2D rb2D;
    public float movementSpeed;

    public float speed;

    private void Start()
    {
       rb2D = GetComponent<Rigidbody2D>();
    }

    // void Update()
    // {
    //     movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    // }

    void FixedUpdate()
    {
       GetInput();
      MoveCharacter(movement);

    //   rb2D.AddForce(movement * speed);
    }

    private void GetInput() {
    
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    public void MoveCharacter(Vector2 movementVector)
    {
        movementVector.Normalize();
        // move the RigidBody2D instead of moving the Transform
        rb2D.velocity = movementVector * movementSpeed;
    }
}
