using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pikable : MonoBehaviour{
    public Item item;
    public GameObject player;//objeto em que o componente de inventario se encontra

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject == player)
        {
            collision.gameObject.GetComponent<Inventory>().add(item);
            Destroy(gameObject);
        }
    }
}