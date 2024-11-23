using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibleFrame : MonoBehaviour
{
    public float duration;
    private float timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = timer - Time.deltaTime < 0 ? 0 : timer - Time.deltaTime; 
    }

    public void activate()
    {
        timer = duration;
        StartCoroutine(blinking());
        deactivateCollider();
    }

    private void deactivateCollider()
    {
        GetComponent<TriggerEvent>().enabled = false;
    }

    private void activateCollider()
    {
        GetComponent<TriggerEvent>().enabled = true;
    }

    private IEnumerator blinking()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        Color defaultColor = sr.color;
        Color hitColor = defaultColor;
        hitColor.a = 0.5f;
        while(timer > 0)
        {
            sr.color = hitColor;
            yield return new WaitForSeconds(0.1f);
            sr.color = defaultColor;
            yield return new WaitForSeconds(0.1f);
        }
        sr.color = defaultColor;
        activateCollider();

    }

}
