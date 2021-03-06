/*
    Author: Ignacio
*/
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Inventory : MonoBehaviour
{   
    public int max_size = 14; 
    public List<Item> inv; 

    //event
    public event InvHandler OnAddElement;
    public delegate void InvHandler(Item item);

    public Inventory()
    {
        inv = new List<Item>(max_size); 
    }

    /******************************************************************
    *                                                                 *
    *  add(Item item): adiciona um item ao array,                     *
    *                  retorna false caso inventario esteja cheio     *
    *                                                                 *
    *******************************************************************/
    public bool add(Item item)
    {
        if(inv.Count > max_size)
            return false;

        inv.Add(item);
        OnAddElement?.Invoke(item);
        return true;
    }

    /******************************************************************
    *                                                                 *
    *  add(params Item[] item): adiciona uma sequencia de items,      * 
    *                  retorna false caso inventario esteja cheio     *
    *                                                                 *
    *******************************************************************/
    public bool add(params Item[] item)
    {
        for(int i = 0; i < item.Length; i++)
            add(item);

        return true;
    }

    /******************************************************************
    *                                                                 *
    *  delete(Item item): remove um item da lista                     * 
    *                                                                 *
    *******************************************************************/
    public void delete(int index)
    {
        inv.RemoveAt(index); 
    }

    /******************************************************************
    *                                                                 *
    *  get(int index): retorna um item da lista                       * 
    *                                                                 *
    *******************************************************************/
    public Item get(int index)
    {
        if(index > max_size || index >= inv.Count)
            return null;
        else
            return inv[index];
    }

    /******************************************************************
    *                                                                 *
    *  getAll(): retorna todos os elementos                           * 
    *                                                                 *
    *******************************************************************/
    public List<Item> getAll()
    {
        return inv;
    }

    /******************************************************************
    *                                                                 *
    *  size(): retorna tamanho do inventario                          * 
    *                                                                 *
    *******************************************************************/
    public int size()
    {
        return inv.Count;
    }

}
