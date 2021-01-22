﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
public Transform thisTransform;   
public Vector3 mousePos;
public Vector3 worldPos;
public Vector3 playerPos;
public float speed = 0.1f;

  void Start(){

   playerPos = thisTransform.position;

  }
    void Update()
    { 
       if (Input.GetMouseButtonDown(0))
       {
        
 
       }     
     
      
      thisTransform.position = Vector3.MoveTowards(thisTransform.position,playerPos,speed);
    }

    public void SetNewDestination()
    {
         mousePos = Input.mousePosition; 
         worldPos = Camera.main.ScreenToWorldPoint(mousePos); 
         playerPos = new Vector3(worldPos.x,playerPos.y,playerPos.z);

    }
}

