using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scenario", menuName = "ScenarioEvent / New 3D Scenario")]
public class x3D : Chapter
{     public void Awake()
    {
        type = ChapterType.x3D;
    }
}
