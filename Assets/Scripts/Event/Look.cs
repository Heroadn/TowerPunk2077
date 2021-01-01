using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v3 = player.transform.position - transform.position;
        v3.y = 0;
        transform.rotation = Quaternion.LookRotation(v3);
    }
}
