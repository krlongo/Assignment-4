/*
     * Kevon Long
     * Fire.cs
     * Assignment #4
     * Sets a zombie to fire
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : ElementDecorator
{
    Zombie zombie;

    public Fire(Zombie zombie)
    {
        this.zombie = zombie;
    }

    public override void movement()
    {
        throw new System.NotImplementedException();
    }

    public override void setElement()
    {
        zombie.GetComponent<SpriteRenderer>().color = new Color(255.0f, 0.0f, 0.0f);
    }
}
