/*
    Author: Benjamin de Castro "Hellkaiser"
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItem : IInventoryItem
{   
    public int icon_id  = 0;

    public bool colocar(){
        return true;
    }
}
