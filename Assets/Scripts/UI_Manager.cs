//using System.Diagnostics;
//using System.Xml.Xsl.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Manager : MonoBehaviour
{
    public InteractableObject activeIO;
    public Text dialog;
    public GameObject Player;
    public PlayerMovement pm;


    public void Displaytext()
    {
        dialog.text = activeIO.inspecttext;

    }

    public void Exit()
    {
        dialog.text = "";
    }

    public void CollectItem()
    {
        Debug.Log("Collect Item");
        activeIO.img.sprite = activeIO.sr.sprite;


        if (activeIO.img.sprite == activeIO.sr.sprite)
        {
            activeIO.gameObject.active = false;

        }
    }

    public void Teleport()
    {
        //player.position.x = irgendwas
        Player.transform.position = new Vector3(68, -4.03f, 0);
        pm.SetDesinationTeleport();
    }
public void TeleportBack()
{
Player.transform.position = new Vector3(6, -4.03f, 0);
  pm.SetDesinationTeleport();
}
}

