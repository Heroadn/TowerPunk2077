using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public LevelDatabase database;
    public GameObject player;
    public int levelIndex;

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject == player)
        {
            database.loadLevel(levelIndex);
        }
            
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
