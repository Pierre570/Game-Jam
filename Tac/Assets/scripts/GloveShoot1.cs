using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveShoot1 : MonoBehaviour
{
    public float speedBox1 = 20f;
    public Rigidbody2D boxrb1;
    public GameObject boximpactEffect1;
    public float damageDealt;

    void Start()
    {
        boxrb1.velocity = transform.right * -speedBox1;
    }
    void OnTriggerEnter2D(Collider2D hitInfo) {
        if (hitInfo.name == "Player") {
            PlayerInfo.health += damageDealt;
            Destroy(gameObject);
        }
        if (hitInfo.name == "WallLeft")
            Destroy(gameObject);
    }
}
