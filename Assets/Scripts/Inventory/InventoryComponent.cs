/*
    Author: Ignacio
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryComponent : MonoBehaviour
{   
    private Inventory inventory; 

    void Start()
    {
        inventory = new Inventory();
    }

    public InventoryItem getItem(int index){
        return inventory.get(index);
    }

    public Inventory getInventory(){
        return inventory;
    }

    public int getInventorySize(){
        return inventory.max_size;
    }

}