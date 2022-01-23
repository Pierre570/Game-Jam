using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class shootRock : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public GameObject player;
    public GameObject SlingShot;
    private float timer = 0.3f;
    private float anim_timer = 0f;
    void Update()
    {
        anim_timer -= Time.deltaTime;
        float dist = firepoint.position.y - player.transform.position.y;
        timer -= Time.deltaTime;
        if (dist <= 25 && dist >= -50) {
            if (timer <= 0) {
                SlingShot.GetComponent<Renderer>().enabled = true;
                anim_timer = 0.5f;
                EnemyShoot();
                timer = 0.3f;
            }
        }
        if (anim_timer <= 0)
            SlingShot.GetComponent<Renderer>().enabled = false;

    }
    void EnemyShoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
