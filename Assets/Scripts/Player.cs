using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public KeyCode left;
    public KeyCode right;
    public Vector3 moveForce;

    void Update()
    {      
       if (Input.GetKey(left))
        {
           rb.AddForce(moveForce); 
        }

        if (Input.GetKey(right))
        {
           rb.AddForce(-moveForce);
        }
    }
}

