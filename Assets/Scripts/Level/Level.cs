using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public enum LevelType
{
    L_2D,
    L_3D,
    MENU,
    PAUSE
}
public abstract class Level : ScriptableObject
{
    [Header("Level General")]
    public int id;
    public string name;
    public LevelType type;
    public Sprite icone;
}