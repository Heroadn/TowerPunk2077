using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour{

    private int size_slots;
    private bool inventoryEnabled;

    public GameObject slotHolder;
    public GameObject inventoryGui;

    private InventoryComponent inventoryComponent;
    private InventorySlot[] slots;

    void Start(){
        //obtendo componente de inventario
        inventoryComponent = GetComponent<InventoryComponent>();
        inventoryComponent.getInventory().add(new Wood(), new Wood(), new ArmadilhaUrso());

        //tamanho de slots e inicializando array
        size_slots = 14;
        slots      = new InventorySlot[size_slots];

        //Janela do inventario desativada no inicio
        inventoryGui.SetActive(inventoryEnabled);

        //Inicializando slots vazios
        for (int i=0; i < size_slots; i++)
        {
            slots[i] = new InventorySlot();
            slots[i].button = slotHolder.transform.GetChild(i).gameObject;

            //prenchendo de items e icones
            if(i < inventoryComponent.getInventorySize())
            {
                slots[i].item = inventoryComponent.getItem(i);
                slots[i].button.GetComponent<Image>().sprite 
                        = Icons.sprites[slots[i].item.icon_id];
            }
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.I)){
            loadInventory();
            inventoryGui.SetActive(inventoryEnabled = !inventoryEnabled);
        }

        //adicionando ao inventario
        if(Input.GetKeyDown(KeyCode.V)){
            inventoryComponent.getInventory().add(new Wood());
        }
    }

    //Todo: simplificar
    void loadInventory(){
        for (int i=0; i < size_slots; i++)
        {
            //prenchendo de items e icones
            if(i < inventoryComponent.getInventorySize())
            {
                Debug.Log("I: "+i);
                Debug.Log("S: "+inventoryComponent.getInventorySize());
                slots[i].item = inventoryComponent.getItem(i);
                slots[i].button.GetComponent<Image>().sprite 
                        = Icons.sprites[slots[i].item.icon_id];
            }
        }
    }
}