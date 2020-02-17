﻿/*
     * Kevon Long
     * IceZombie.cs
     * Assignment #4
     * Moves towards the player as the ice zombie
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceZombie : Zombie
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(0.0f, 225.0f, 225.0f);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    public override void movement()
    {
        rb.velocity = new Vector2(-20.0f, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            SceneSwitcher.Lose();
        }

    }
}