using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FgParallax : MonoBehaviour
{
    private float length, startPos;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void LateUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float distance = (cam.transform.position.x * parallaxEffect);

        // changed startPos + distance > startPos - distance 
        // turned parallax slowing bg down > parallax speeding fg up
        transform.position = new Vector3(startPos - distance, transform.position.y, transform.position.z);

    }
}