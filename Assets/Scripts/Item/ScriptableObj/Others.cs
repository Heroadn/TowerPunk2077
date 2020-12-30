using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Others")]
public class Others : Item
{
    [Header("Others Attribute")]
    public string Usefull;
    
     public void Awake()
    {
        type = ItemType.Others;
    }
}
