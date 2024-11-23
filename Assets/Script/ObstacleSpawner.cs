using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacle;
    public float timeDelay = 6;
    private int index;
    float timer;

    void Start()
    {
        timer = timeDelay;  
    }

    void Update()
    {
        Vector3 obstaclePosition;
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            if (obstacle[index].tag == "Platform")
            {
                obstaclePosition = new Vector3(transform.position.x, Random.Range(8, 9), transform.position.z);
            } 
            else if (obstacle[index].name == "Saw")
            {
                obstaclePosition = new Vector3(transform.position.x, Random.Range(4, 11), transform.position.z);
            }
            else
            {
                obstaclePosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }   
            Instantiate(obstacle[index], obstaclePosition, transform.rotation);
            index = Random.Range(0, 3);
            timer = timeDelay;
        }
    }

}
