using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Key")]
public class Key : Item
{
    [Header("Key Attribute")]
    public string Keycode;
    
     public void Awake()
    {
        type = ItemType.Key;
    }
}
