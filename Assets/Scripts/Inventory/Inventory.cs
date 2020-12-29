/*
    Author: Benjamin de Castro "Hellkaiser"
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{   
    public List<InventoryItem> inv; 
    public int max_size = 14; 

    public Inventory()
    {
        inv = new List<InventoryItem>(); 
    }

    public Inventory(List<InventoryItem> inventory)
    {
        inv = inventory;
    }

    /*
        Adicionar(IInventoryItem item): Caso a função retorne false
        significa que o inventario esta cheio
    */
    public bool add(InventoryItem item)
    {
        if(inv.Count > max_size)
            return false;

        inv.Add(item);
        return true;
    }

    public void delete(InventoryItem item)
    {
        //TODO: função de remover item do inventario
    }

    public InventoryItem get(int index)
    {
        if(index > max_size || index >= inv.Count)
            return null;
        else
            return inv[index];
    }

    public List<InventoryItem> getAll(){
        return inv;
    }

    public InventoryItem search(InventoryItem item)
    {
        //TODO: função de procurar item no inventario
        return null;
    }
}
