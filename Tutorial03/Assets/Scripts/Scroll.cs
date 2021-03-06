﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -1.5)
        {
            Destroy(gameObject);
        }
    }
}
