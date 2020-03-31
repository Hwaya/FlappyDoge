using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D bc;

    public float groundSizeX;
    public float groundSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();

        groundSizeX = 3.0f;

        rb.velocity = new Vector2(-groundSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -groundSizeX)
        {
            Vector2 groundOffSet = new Vector2(groundSizeX * 2, 0);
            transform.position = (Vector2)transform.position + groundOffSet;
        }
    }
}
