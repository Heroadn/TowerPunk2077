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
        player = GameObject.Find("PlayerHeart");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v3 = player.transform.position - transform.position;
        v3.y -= 12;
        transform.rotation = Quaternion.LookRotation(v3);
    }
}
