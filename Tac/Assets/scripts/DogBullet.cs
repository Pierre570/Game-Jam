using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBullet : MonoBehaviour
{
    public float speedBullet = 20f;
    public Rigidbody2D enrb;
    public GameObject enimpactEffect;
    private int rockHits = 3;

    void Start()
    {
        rockHits = 3;
        enrb.velocity = transform.right * -speedBullet;
    }
    void OnTriggerEnter2D(Collider2D hitInfo) {
        Debug.Log("hit something");
        if (hitInfo.name == "Player") {
            Debug.Log("hit player");
            PlayerInfo.health += 10;
            Destroy(gameObject);
        }
        if (hitInfo.name == "WallLeft")
            Destroy(gameObject);
        else if (hitInfo.name != "DogBullet")
            rockHits -= 1;
    }
    void Update()
    {
        if (rockHits <= 0)
            Destroy(gameObject);
    }
}
