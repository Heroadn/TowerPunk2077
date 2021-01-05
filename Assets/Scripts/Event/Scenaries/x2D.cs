using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scenario", menuName = "ScenarioEvent / New 2D Scenario")]
public class x2D : Chapter
{     public void Awake()
    {
        type = ChapterType.x2D;
    }
}
