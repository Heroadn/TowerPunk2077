/*
    Author: Benjamin de Castro "Hellkaiser" 
        & Ignacio "Oicanji"
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Movement
{
    //attributes
    public int food;
    public int water;
    public Inventory inventory;

    //construtor
    public Player()
    {
        inventory = new Inventory(); 
    }
}