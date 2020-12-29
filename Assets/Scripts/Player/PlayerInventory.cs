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
    private InventoryButton[] slots;

    void Start(){
        //obtendo componente de inventario
        inventoryComponent = GetComponent<InventoryComponent>();
        inventoryComponent.getInventory().add(new Wood(), new ArmadilhaUrso());

        //tamanho de slots e inicializando array
        size_slots = inventoryComponent.getInventorySize();
        slots      = new InventoryButton[size_slots];

        //Janela do inventario desativada no inicio
        inventoryGui.SetActive(inventoryEnabled);

        //Inicializando slots vazios
        for (int i=0; i < size_slots; i++)
        {
            slots[i] = new InventoryButton();
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
            inventoryGui.SetActive(inventoryEnabled = !inventoryEnabled);
        }
    }
}