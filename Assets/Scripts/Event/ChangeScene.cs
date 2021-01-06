using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    private LevelManager manager;
    public GameObject player;
    public int levelIndex;

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject == player)
        {
            manager.loadLevel(levelIndex);
        }
            
    }

    void Start()
    {
        manager = GameObject.Find("GameSystem").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
