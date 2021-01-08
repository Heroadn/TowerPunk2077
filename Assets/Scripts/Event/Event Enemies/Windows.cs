/*
    Author: Benjamin de Castro "Hellkaiser" 
        & Ignacio "Oicanji"
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windows : MonoBehaviour{
    public bool IsOpen;
    public bool IsBroken;

    public Sprite WindowsClear;
    public Sprite WindowsBroke;
    public Sprite WindowsClose;
    public Sprite Nacaguro;

    public bool NacaguroHere;
    private SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = WindowsClear;
    }
    void WindowsCleared(){
        spriteRenderer.sprite = WindowsClear;
    }
    void WindowsBreak(){
        spriteRenderer.sprite = WindowsBroke;
    }
    void WindowsClosed(){
        spriteRenderer.sprite = WindowsClose;
    }
    void WindowsNacaguro(){
        spriteRenderer.sprite = Nacaguro;
    }
}