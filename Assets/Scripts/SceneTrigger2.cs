using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger2 : MonoBehaviour
{
    public Animator moon;
    
    void Start()
    {
        moon = moon.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            moon.SetTrigger("MoonTrigger"); 
    }
}
