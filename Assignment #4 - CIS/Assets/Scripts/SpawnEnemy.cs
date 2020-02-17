/*
     * Kevon Long
     * SpawnEnemy.cs
     * Assignment #4
     * Spawns zombies
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject zombieSpawn;
    public Zombie iceZombie, fireZombie;
    public float firerate;
    float nextFire;

    public List<Zombie> zombies;

    // Start is called before the first frame update
    void Start()
    {
        zombies.Add(iceZombie);
        zombies.Add(fireZombie);
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            if(gameObject.tag == "IceSpawner")
            {
                Instantiate(zombies[Random.Range(0,2)], transform.position, transform.rotation);
            }

            nextFire = Time.time + firerate;
        }
    }
}
