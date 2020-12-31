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

<<<<<<< HEAD
    private Inventory inventory;
    private Slot[] slots;
=======
    public Item[] listaDeItems;

    private InventoryComponent inventoryComponent;
    private InventorySlot[] slots;
>>>>>>> 6c0c0a3bb1c9fd4313287bdd6c81e0a8ab8144e5

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