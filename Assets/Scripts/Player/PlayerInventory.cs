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

    void Start(){
        //obtendo componente de inventario
        inventory = GetComponent<Inventory>();
        //inventoryComponent.getInventory().add(new Wood(), new Wood(), new ArmadilhaUrso());

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

            //prenchendo de items e icones
            if(i < inventory.size())
            {
                slots[i].item = inventory.get(i);
                if(slots[i].item == null)
                    continue;

                slots[i].button.GetComponent<Image>().sprite 
                    = Icons.sprites[slots[i].item.Id];
            }
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