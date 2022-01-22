using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float en_move_speed = 100f;

    public Rigidbody2D rb;
    
    Vector2 movement;

    public GameObject Dog;

    private bool up = true;

    private bool down = false;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("hit something");
        if (hitInfo.name == "Ceiling") {
            Debug.Log("hit ceiling");
            down = true;
            up = false;
        }
        else if (hitInfo.name == "Floor") {
            Debug.Log("hit floor");
            down = false;
            up = true;
        }
    }

    void Update()
    {
        if (up)
            movement.y = 1;
        else if (down)
            movement.y = -1;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * en_move_speed * Time.fixedDeltaTime);
    }
}
