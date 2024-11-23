using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform anchor;
    [SerializeField] private float shootingPower;
    [SerializeField] private float maxAmmo;
    public float currentAmmo;
    [SerializeField] private float reloadTime;

    public GameObject reloadText;
    private bool isReloading = false;

    void Start()
    {
        currentAmmo = maxAmmo;
    }

    void Update()
    {
        if (isReloading)
        {
            return;
        }

        {
            
        }
        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            Execute();
            currentAmmo--;
        }
    }

    // Start is called before the first frame update
    private void Execute()
    {
        GameObject go = SpawnProjectile();
        Projectile p = go.GetComponent<Projectile>(); 
        p.SetVelocity(anchor, shootingPower);
    }

    private GameObject SpawnProjectile()
    {
        return Instantiate(projectilePrefab, anchor.position, anchor.rotation);
    }

    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading");
        reloadText.SetActive(true);
        yield return new WaitForSeconds(reloadTime);
        
        currentAmmo = maxAmmo;
        isReloading = false;
        reloadText.SetActive(false);
    }
}
