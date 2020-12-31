using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pikable : MonoBehaviour{
    public Item item;
    public string PlayerGameobjName; 

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == PlayerGameobjName)
        {
            collision.gameObject.GetComponent<Inventory>().add(item);
            Destroy(gameObject);
        }
    }
}