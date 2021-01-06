using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    public GameObject player;
    public GameObject placeToTeleport;

    void OnTriggerEnter(Collider collision){
        player.transform.position = placeToTeleport.transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
