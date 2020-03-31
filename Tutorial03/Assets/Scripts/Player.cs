using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rd;
    public float power = 100.0f;

    public GM gm;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        gm = GetComponent<GM>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GM.singleton.GameOver = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GM.singleton.Score++;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position *= Vector2(0.0f, 1.0f);
        if(Input.GetMouseButtonDown(0))
        {
            rd.velocity = Vector2.zero;
            rd.AddForce(Vector2.up * (power * 1.5f));
        }
    }
}
