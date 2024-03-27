using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class SceneTrigger : MonoBehaviour
{
    bool isTriggered = false;
    public SpriteRenderer background;
    public Sprite newBackground;
    public Light2D skyLighting;
    public Volume volume1;
    public Volume volume2;
    public GameObject bridge1;
    public GameObject bridge2;
    public GameObject bridgeLight;

    public GameObject sick1;
    public GameObject sick2;
    public GameObject sick3;
    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject foliage1;

    void Update()
    {
        if(isTriggered == true)
        {
            background.sprite = newBackground;
            skyLighting.intensity = 0.7f;
            volume1.enabled = false;
            volume2.enabled = true;
            bridge1.SetActive(false);
            bridge2.SetActive(true);
            bridgeLight.SetActive(true);

            sick1.SetActive(true);
            sick2.SetActive(true);
            sick3.SetActive(true);
            tree1.SetActive(false);
            tree2.SetActive(false);
            tree3.SetActive(false);
            foliage1.SetActive(true);

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isTriggered = true;
    }
}
