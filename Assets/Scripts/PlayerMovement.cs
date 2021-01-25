using System.Collections;
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

    void Start()
    {

        playerPos = thisTransform.position;

    }
    void Update()
    {
        if (thisTransform.position != playerPos)
        {
            thisTransform.position = Vector3.MoveTowards(thisTransform.position, playerPos, speed);
           
        }

        if ( thisTransform.position.x < playerPos.x)
        {
          transform.rotation = Quaternion.Euler(0f,180f,0f);
        }
        else if (thisTransform.position.x > playerPos.x)
        {
            transform.rotation = Quaternion.Euler(0f,0f,0f);
        }

  }
    

    public void SetNewDestination()
    {
        mousePos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        playerPos = new Vector3(worldPos.x, playerPos.y, playerPos.z);
    }
    public void SetDesinationTeleport()
    {
        playerPos = new Vector3(transform.position.x, playerPos.y, transform.position.z);
    }

    
}

