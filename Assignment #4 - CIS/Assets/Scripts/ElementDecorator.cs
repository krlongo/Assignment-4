/*
     * Kevon Long
     * ElementDecorator.cs
     * Assignment #4
     * Gives the decorators their super inheritcance from zombie and lets them set elements
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ElementDecorator : Zombie
{
    public abstract void setElement();
}
