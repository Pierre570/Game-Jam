using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speedBullet = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speedBullet;
    }
    void OnTriggerEnter2D(Collider2D hitInfo) {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
