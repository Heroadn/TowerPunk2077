using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateRay : MonoBehaviour
{
    public GameObject player;
    float vecDirection = 0;
    float vecDistance = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        vecDirection = (player.transform.rotation.y - gameObject.transform.rotation.y);
        gameObject.transform.Rotate(0, 0, vecDirection);    
    }
}
