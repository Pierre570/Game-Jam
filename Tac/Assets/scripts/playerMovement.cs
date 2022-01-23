using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float move_speed = 100f;

    public Rigidbody2D rb;
    
    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.E))
            PlayerInfo.health += 5;
        if (Input.GetKeyDown(KeyCode.F))
            PlayerInfo.enhealth += 5;
        if (Input.GetKeyDown(KeyCode.Escape))
            PlayerInfo.ChangeScene("Menu");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * move_speed * Time.fixedDeltaTime);
    }
}
