using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerInventory : MonoBehaviour{

    private int size_slots;
    private bool inventoryEnabled;

    public GameObject[] slots;
    public GameObject slotHolder;
    public GameObject inventoryGui;

    private InventoryComponent inventoryComponent;

    void Start(){
        //obtendo componente de inventario
        inventoryComponent = GetComponent<InventoryComponent>();
        inventoryComponent.getInventory().add(new Wood(), new ArmadilhaUrso());

        //tamanho de slots e inicializando array
        size_slots = inventoryComponent.getInventorySize();
        slots      = new GameObject[size_slots];

        //Janela do inventario desativada no inicio
        inventoryGui.SetActive(inventoryEnabled);

        //Inicializando slots vazios
        for (int i=0; i < size_slots; i++)
            slots[i] = slotHolder.transform.GetChild(i).gameObject;

        //Preenchendo array de icones
        int code = (inventoryComponent.getItem(0) != null)?
                        inventoryComponent.getItem(0).icon_id : 0;

        for(int i = 0;  
            i < size_slots && 
            i < inventoryComponent.getInventorySize();
            i++, code = inventoryComponent.getItem(i).icon_id)
        {
            slots[i].GetComponent<Image>().sprite = Icons.sprites[code];
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.I)){
            inventoryGui.SetActive(inventoryEnabled = !inventoryEnabled);
        }
    }
}