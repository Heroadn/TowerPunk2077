using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject place;
    public int MAX_CREATURES;
    private int count = 0;

    void Start()
    {
        place.AddComponent<ParticleSystem>();
        place.GetComponent <ParticleSystem>().Play ();
    }

    void Update()
    {
        if(count < MAX_CREATURES)
        {
            //GameObject instantiated = Instantiate(prefab, place.position.transform);
            //instantiated.transform.SetParent(place);
        }
    }
}
