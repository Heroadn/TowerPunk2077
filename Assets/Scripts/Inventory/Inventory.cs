/*
    Author: Benjamin de Castro "Hellkaiser"
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{   
    public List<IInventoryItem> inv;

    public Inventory()
    {
        inv = new List<IInventoryItem>(); 
    }

    public void adicionar(IInventoryItem item)
    {
        inv.Add(item);
    }

    public void remover(IInventoryItem item)
    {
        //TODO: função de remover item do inventario
    }

    public IInventoryItem peguar(int index)
    {
        return inv[index];
    }

    public IInventoryItem procurar(IInventoryItem item)
    {
        //TODO: função de procurar item no inventario
        return null;
    }
}
