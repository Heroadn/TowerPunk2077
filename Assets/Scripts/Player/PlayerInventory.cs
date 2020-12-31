using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*relaciona icone com o item*/
public struct Slot{
    public Item item;
    public GameObject button;
}

public class PlayerInventory : MonoBehaviour{

    private int size_slots;
    private bool inventoryEnabled;

    public GameObject slotHolder;
    public GameObject inventoryGui;
    
    private Inventory inventory;
    private Slot[] slots;

    /*relaciona id do item com icone*/
    struct Slot
    {
        public int id_item;
        public GameObject gameObject;
    }    

    void Start(){
        //obtendo inventario
        inventory = GetComponent<Inventory>();
        slots = new Slot[14];

        //Janela do inventario desativada no inicio
        inventoryGui.SetActive(inventoryEnabled);

        //Criando slots
        for (int i=0; i < size_slots; i++)
        {
            slots[i].gameObject = slotHolder.transform.GetChild(i).gameObject;
        }

        //Adicionando icones
        for (int i=0; i < inventory.size(); i++)
        {
            slots[i].gameObject.GetComponent<Image>().sprite = inventory.get(i).uiDisplay;
            slots[i].id_item = inventory.get(i).Id;
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.I)){
            inventoryGui.SetActive(inventoryEnabled = !inventoryEnabled);
        }

        //adicionando ao inventario
        if(Input.GetKeyDown(KeyCode.V)){
            //inventoryComponent.getInventory().add(new Wood());
        }
    }
}