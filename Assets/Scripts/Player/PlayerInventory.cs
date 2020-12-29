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
        inventoryComponent.getInventory().add(new Wood());

        //tamanho de slots e inicializando array
        size_slots = inventoryComponent.getInventorySize();
        slots      = new GameObject[size_slots];

        //GUI desativada no inicio
        inventoryGui.SetActive(inventoryEnabled);

        //Inicializando slots vazios
        for (int i=0; i < size_slots; i++)
            slots[i] = slotHolder.transform.GetChild(i).gameObject;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.I)){
            
            for(int i = 0; i < inventoryComponent.getInventorySize(); i++)
                Debug.Log("Hello"+inventoryComponent.getItem(i)+slots[i].gameObject);

            inventoryGui.SetActive(inventoryEnabled = !inventoryEnabled);
        }
    }
}