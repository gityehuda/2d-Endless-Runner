using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float lifeTime;

    // Start is called before the first frame update
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>(); ;   
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0f )
        {
            Destroy(gameObject);
        }
    }

    public void SetVelocity(Transform anchor, float shootingPower)
    {
        rb2d.velocity = anchor.right * shootingPower;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Debug.Log("Hit");
        }
    }
        
}
