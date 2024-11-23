using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeUI : MonoBehaviour
{
    public TMP_Text textLife;
    public TMP_Text textAmmo;
    [SerializeField] private MyLife life;
    [SerializeField] private Shooting shooting;

    void Update()
    {
        textLife.text = life.life.ToString();
        textAmmo.text = shooting.currentAmmo.ToString();
    }

}
