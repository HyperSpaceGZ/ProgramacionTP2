using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Player
    public float movementspeed;
    public Rigidbody2D rb;
    Vector2 Movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementXY();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * movementspeed * Time.deltaTime);
    }

    private void MovementXY()
    {
        Movement.x = Input.GetAxis("Horizontal");
    }
}
