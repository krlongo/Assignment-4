/*
     * Kevon Long
     * BulletBehavior.cs
     * Assignment #4
     * Makes the bullet move and take a decorator
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private Rigidbody2D rb;
    public Zombie zombie;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(10.0f, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        zombie = new Ice(zombie);
    }

}
