/*
     * Kevon Long
     * Player.cs
     * Assignment #4
     * Shoots bullets at zombies
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject fireBullet, iceBullet;
    float fireElapsedTime = 0;
    public float fireDelay = .5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireElapsedTime += Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Mouse0) && fireElapsedTime >= fireDelay)
        {
            Instantiate(fireBullet, transform.position, transform.rotation);
            fireElapsedTime = 0;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && fireElapsedTime >= fireDelay)
        {
            Instantiate(iceBullet, transform.position, transform.rotation);
            fireElapsedTime = 0;
        }
    }



}
