using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LinearDrag : MonoBehaviour
{
    public Rigidbody2D player;
    public float dragAmount;

    private void OnTriggerStay2D(Collider2D other)
    {
        //change linear drag of player so they don't slip off slopes
        player.drag = dragAmount;

        Debug.Log("change");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        player.drag = 0f;
    }

}
