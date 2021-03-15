using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;

public class JoystickControl : MonoBehaviour
{
    public DynamicJoystick dynamicJoystick;
    
    public float acceleration;
    public float steering;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (rb.position.x < -2.5)
            rb.position = new Vector2(-2.5f, rb.position.y);
        if (rb.position.x > 2.5)
            rb.position = new Vector2(2.5f, rb.position.y);
        
        rb.velocity = new Vector2(dynamicJoystick.Horizontal * acceleration, dynamicJoystick.Vertical * acceleration);

        rb.rotation = Mathf.Asin(dynamicJoystick.Horizontal) * -Mathf.PI * acceleration;
    }
}