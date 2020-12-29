/*
    Author: Benjamin de Castro "Hellkaiser"
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icons : MonoBehaviour
{
    public enum Icon { WOOD, TRAP };

    public static Sprite[] sprites = { 
         Resources.Load<Sprite>("/Textures/images"),//WOOD
         Resources.Load<Sprite>("/Textures/images")//TRAP
        };
}