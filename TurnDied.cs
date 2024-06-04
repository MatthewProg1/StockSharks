using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnDied : MonoBehaviour
{
    Rigidbody2D rb;
    float move;
    public Joystick joystick;
 


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = joystick.Horizontal;

        rb.velocity = new Vector2(move * 10, rb.velocity.y);
    }
}
