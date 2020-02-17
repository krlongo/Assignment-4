/*
     * Kevon Long
     * Ice.cs
     * Assignment #4
     * Turns a zombie into ice
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : ElementDecorator
{
    Zombie zombie;

    public Ice(Zombie zombie)
    {
        this.zombie = zombie;
    }

    public override void movement()
    {
        throw new System.NotImplementedException();
    }

    public override void setElement()
    {
        zombie.GetComponent<SpriteRenderer>().color = new Color(0.0f, 225.0f, 225.0f);
    }
}
