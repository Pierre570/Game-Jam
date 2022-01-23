using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveShoot : MonoBehaviour
{
    public Transform firepoint2;
    public GameObject BoxPrefab1;
    public GameObject BoxPrefab2;
    public GameObject BoxPrefab3;
    public GameObject player;
    public GameObject Glove;
    private float timer = 1f;
    private float anim_timer = 0f;
    private int boxType = 0;
    void Update()
    {
        anim_timer -= Time.deltaTime;
        float dist = firepoint2.position.y - player.transform.position.y;
        timer -= Time.deltaTime;
        if (dist <= 25 && dist >= -50) {
            if (timer <= 0) {
                Glove.GetComponent<Renderer>().enabled = true;
                anim_timer = 0.3f;
                EnemyShoot();
                timer = 1f;
            }
        }
        if (anim_timer <= 0)
            Glove.GetComponent<Renderer>().enabled = false;

    }
    void EnemyShoot()
    {
        if (boxType == 0) {
            Instantiate(BoxPrefab1, firepoint2.position, firepoint2.rotation);
            boxType = 1;
        }
        else if (boxType == 1) {
            Instantiate(BoxPrefab2, firepoint2.position, firepoint2.rotation);
            boxType = 2;
        }
        else if (boxType == 2) {
            Instantiate(BoxPrefab3, firepoint2.position, firepoint2.rotation);
            boxType = 0;
        }
    }
}
