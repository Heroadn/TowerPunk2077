using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Level", menuName = "Level/New 3D")]
public class Level3D : Level
{
    [Header("Level specific")]
    public string info;

    public void Awake()
    {
        type = LevelType.L_3D;
    }
}
