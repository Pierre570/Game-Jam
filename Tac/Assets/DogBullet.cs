using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBullet : MonoBehaviour
{
    public float speedBullet = 20f;
    public Rigidbody2D enrb;
    public GameObject enimpactEffect;

    void Start()
    {
        enrb.velocity = transform.right * -speedBullet;
    }
    void OnTriggerEnter2D(Collider2D hitInfo) {
        Debug.Log("hit something");
        if (hitInfo.name == "Player") {
            Debug.Log("hit player");
            PlayerInfo.health += 5;
            Destroy(gameObject);
        }
    }
}
