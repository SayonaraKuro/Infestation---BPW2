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
    public Light2D lighting;
    public Light2D spotLight1;
    public Volume volume1;
    public Volume volume2;

    void Update()
    {
        if(isTriggered == true)
        {
            background.sprite = newBackground;
            lighting.intensity = 0.4f;
            spotLight1.enabled = true;
            volume1.enabled = false;
            volume2.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isTriggered = true;
    }
}
