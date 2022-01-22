using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speedBullet = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    void Start()
    {
        rb.velocity = transform.right * speedBullet;
    }
    void OnTriggerEnter2D(Collider2D hitInfo) {
        if (hitInfo.name == "Ennemy")
            PlayerInfo.enhealth += 5;
        Destroy(gameObject);
    }
}
