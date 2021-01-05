using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChapterType
{
    x3D,
    x2D
}
public abstract class Chapter : ScriptableObject
{
    [Header("Scene General")]
    public int Id;
    
    public ChapterType type;
    public string sceneName;
    public string sceneIndex;

    [Header("Event General")]

    public string EventName;

    [TextArea(10, 20)]
    public string EventDesc;
}