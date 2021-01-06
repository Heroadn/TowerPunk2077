using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

[CreateAssetMenu(fileName = "New Level", menuName = "Level/New Level")]
public class Level : ScriptableObject
{
    [Header("Level General")]
    public Sprite icone;
    
    [TextArea(10, 20)]
    public string desc;

    [Header("Level Loading")]
    public string name;
}