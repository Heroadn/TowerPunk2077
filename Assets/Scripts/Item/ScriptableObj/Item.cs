using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Note,
    Material,
    Key
}
public abstract class Item : ScriptableObject
{
    [Header("Item General")]
    public int Id;
    public string Name;
    public ItemType type;

    [TextArea(10, 20)]
    public string desc;

    public Sprite uiDisplay;
}