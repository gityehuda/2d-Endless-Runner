using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float speed;
    public GameObject[] gameObjects;
    
    // Update is called once per frame
    void Update()
    {
        foreach(GameObject go in gameObjects)
        {
            go.transform.position += Vector3.left * Time.deltaTime * speed;
            if(go.transform.position.x <= -27.9f) 
            {
                go.transform.position = new Vector3(27.9f, 0, 0);
            }
        }
    }
}
