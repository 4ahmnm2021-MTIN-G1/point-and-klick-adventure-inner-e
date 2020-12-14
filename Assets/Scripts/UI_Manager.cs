//using System.Diagnostics;
//using System.Xml.Xsl.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
 public InteractableObject activeIO;
 public Text dialog;

public void Displaytext()
{
dialog.text = activeIO.inspecttext;

}

public void Exit(){
dialog.text = "";
}

public void CollectItem(){
    Debug.Log ("Collect Item");
    activeIO.img.sprite = activeIO.sr.sprite;


if (activeIO.img.sprite == activeIO.sr.sprite)
{
activeIO.gameObject.active = false; 


}
}
public void ChangeScene(){
SceneManager.LoadScene ("Schuppen");
}


}

