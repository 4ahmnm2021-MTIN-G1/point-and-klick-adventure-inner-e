//using System.Xml.Xsl.Runtime;
//using System.Runtime.InteropServices;
//using System.Reflection.PortableExecutable;
//using System.Threading.Tasks.Dataflow;
using System.ComponentModel.Design;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
public GameObject commandmenu;
public UI_Manager man;
public Text dialog;
public string inspecttext;
public SpriteRenderer sr;
public Image img;
//public Transform Reposition;


    // Start is called before the first frame update
  public void Start()

    {
    commandmenu.active = false; 
    }
public void Update() 
{ 
   
}
  public void OnMouseDown()
 {
     commandmenu.active = true;
     commandmenu.transform.position = transform.position;
     man.activeIO = this;
     //dialog.text = inspecttext;
  }
  
  
  
}
