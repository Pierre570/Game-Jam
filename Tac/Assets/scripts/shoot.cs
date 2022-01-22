using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerShoot();
        }   
    }
    void PlayerShoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
