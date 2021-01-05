using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Note")]
public class Note : Item
{
    [Header("Note Attribute")]

    [TextArea(10, 20)]
    public string info;

    public Sprite background;
    public Sprite ImgIllustration;
    
     public void Awake()
    {
        type = ItemType.Note;
    }
}