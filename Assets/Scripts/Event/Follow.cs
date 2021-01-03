using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject player;
    public double distancia_longe;
    public int speed;

    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        //player.transform.x
    }

    // Update is called once per frame

    void Update()
    {
        //calculando distancia d = v*t
        float step = speed * Time.deltaTime;

        //a distancia entre os dois > distancia_longe
        if(Math.Abs(transform.position.x - player.transform.position.x) > distancia_longe)
        {
            step = speed * Time.deltaTime;
            pos.y = transform.position.y;
        }
        else
        {
            step = 0;
        }

        //executando realocamento
        pos = Vector3.MoveTowards(transform.position, player.transform.position, step);

        
        //Debug.Log(Math.Abs(transform.position.x - player.transform.position.x));
        

        transform.position = pos;

    }
}
