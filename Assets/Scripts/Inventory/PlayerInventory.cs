﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour{

    private bool inventoryEnabled;
    public GameObject inventoryGui;

    private int allSlots;
    private int enabledSlots;
    private GameObject[] slot;

    public GameObject slotHolder;

    void Start(){
        allSlots = 14;
        slot = new GameObject[allSlots];

        for (int i=0; i < allSlots; i++){
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.I)){
            inventoryEnabled = !inventoryEnabled;
             Debug.Log("Hello");
        }
        
        if(inventoryEnabled == true)
        {
            inventoryGui.SetActive(true);
        } else {
            inventoryGui.SetActive(false);
        }
    }
}