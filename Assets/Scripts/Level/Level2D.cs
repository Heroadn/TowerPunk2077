using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Level", menuName = "Level/New 2D")]
public class Level2D : Level
{
    [Header("Level Attribute")]

    [TextArea(10, 20)]
    public string info;

    public void Awake()
    {
        type = LevelType.L_2D;
    }
}

