 /*
    Author: Ignacio
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHeight : MonoBehaviour {
 
     public GameObject ball;
     float width;
     float height;
     GameObject myball;
     RectTransform rt;
     
     // Use this for initialization
     void Start () {
 
         myball = (GameObject)Instantiate(ball);
         rt = (RectTransform)myball.transform;
         
         width = rt.rect.width;
         height = rt.rect.height;                

         Debug.Log("width: "+width+" | Height: ");
         
         
         }
 }