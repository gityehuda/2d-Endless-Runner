using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLife : MonoBehaviour
{
    public int life;

    public void OnHit()
    {
        if(life <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            life = life - 1 < 0 ? 0 : life - 1;
            if(life <= 0 )
            {
                Destroy(gameObject);
            }
        }
    }

}
