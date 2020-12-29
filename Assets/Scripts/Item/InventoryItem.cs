/*
    Author: Benjamin de Castro "Hellkaiser"
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItem : IInventoryItem
{   
    public virtual int icon_id { get; set; }

    public bool colocar(){
        return true;
    }
}
