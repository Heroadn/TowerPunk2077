using System.Collections;
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
    private int index;
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
            addToGUI(inventory.get(i));
            index = i;
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
    *  subscribe(Inventory inventory): chame esta função  apenas uma  *
                                       vez para ser notificado  de    *
    *                                  mudanças no inventario         *
    *******************************************************************/
    public void subscribe(Inventory inventory)
    {
        //increvendo em eventos de add no inventario
        inventory.OnAddElement += new Inventory.InvHandler(addToGUI);
    }

    /******************************************************************
    *  addToGUI(Inventory inventory): adiciona itens a GUI(id e img)  *
    *******************************************************************/
    public void addToGUI(Item item)
    {
        slots[index].id_item = item.Id;
        slots[index].button.GetComponent<Image>().sprite = item.uiDisplay;
        index++;
    }
}