using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchMe : MonoBehaviour
{
    public GameObject player;
    public int distancia = 10;

    // Start is called before the first frame update
    void Start()
    {
        //player.transform.x
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((player.transform.position.x * Time.deltaTime) - distancia,0,0);
    }
}
