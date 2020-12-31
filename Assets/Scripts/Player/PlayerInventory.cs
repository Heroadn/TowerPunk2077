﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

/*relaciona icone com o item*/
public struct Slot{
    public int id_item;
    public GameObject button;
}

public class PlayerInventory : MonoBehaviour{

    private int size_slots;
    private int last_index;
    private bool inventoryEnabled;

    public GameObject slotHolder;
    public GameObject inventoryGui;

    private Inventory inventory;
    private Slot[] slots;

    void Start(){
        //obtendo componente de inventario
        inventory = GetComponent<Inventory>();

        //tamanho de slots e inicializando array
        size_slots = 14;
        slots      = new Slot[size_slots];

        //Janela do inventario desativada no inicio
        inventoryGui.SetActive(inventoryEnabled);

        //Inicializando slots vazios
        for (int i=0; i < size_slots; i++)
        {
            slots[i] = new  Slot();
            slots[i].button = slotHolder.transform.GetChild(i).gameObject;
        }

        //prenchendo de icones
        for (int i=0; i < inventory.size(); i++)
        {
            slots[i].id_item = inventory.get(i).Id;
            slots[i].button.GetComponent<Image>().sprite = inventory.get(i).uiDisplay;
            last_index = i;
        }

        //ouvindo todas as mudanças no inventario
        subscribe(inventory);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.I)){
            inventoryGui.SetActive(inventoryEnabled = !inventoryEnabled);
        }

        //adicionando ao inventario
        if(Input.GetKeyDown(KeyCode.V)){
            inventory.add(inventory.get(0));
        }
    }

    /******************************************************************
    *  subscribe(Inventory inventory): qualquer mudança no inventario *
    *                                  faz ela ser chamada            *
    *******************************************************************/
    public void subscribe(Inventory inventory)
    {
        inventory.OnAddElement += new Inventory.InvHandler(doAction);
    }

    /******************************************************************
    *  doAction(Inventory inventory): subscribe chama esta função caso*
    *                                tenha uma alteração no inventario*
    *******************************************************************/
    private void doAction(Item item, EventArgs e)
    {
        
        slots[last_index + 1].id_item = item.Id;
        slots[last_index + 1].button.GetComponent<Image>().sprite = item.uiDisplay;
        last_index++;
    }
}