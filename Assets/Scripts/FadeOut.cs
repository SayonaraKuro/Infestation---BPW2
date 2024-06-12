using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public SpriteRenderer spriteRender;
    public Animator animator;
    public bool enter;

    void Start()
    {
        animator = GetComponent<Animator>();
        enter = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // //make temporary variable to store color
        // Color temp =  spriteRender.GetComponent<SpriteRenderer>().color;

        // temp.a = 0f;

        // //change alpha to 0 to make it "disappear"
        // spriteRender.GetComponent<SpriteRenderer>().color = temp;

        // Debug.Log("Disappear");

        animator.SetBool("Enter", true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // //revert alpha to 100
        // Color temp = spriteRender.GetComponent<SpriteRenderer>().color;

        // temp.a = 100f;

        // spriteRender.GetComponent<SpriteRenderer>().color = temp;

        // Debug.Log("Appear");

        animator.SetBool("Enter", false);
    }
}
