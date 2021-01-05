using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Database", menuName = "Level/New Database")]
public class LevelDatabase : ScriptableObject{

    public List<Level> levels = new List<Level>();

    
}