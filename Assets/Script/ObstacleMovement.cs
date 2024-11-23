using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 1f;
    private float maxTravelDistance = -27f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        if(transform.position.x <= maxTravelDistance)
        {
            Destroy(gameObject);
        }
    }
}
