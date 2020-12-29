/*
    Author: Benjamin de Castro "Hellkaiser"
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Icons : MonoBehaviour
{
    public enum Icon { WOOD, TRAP };

    public static Sprite[] sprites = { 
         Resources.Load<Sprite>("Assets/Textures/images"),//WOOD
         Resources.Load<Sprite>("Assets/Textures/images")//TRAP
        };
}