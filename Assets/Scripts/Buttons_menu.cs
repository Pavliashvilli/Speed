using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons_menu : MonoBehaviour
{
    

    void OnMouseUpAsButton (){
        switch (gameObject.name){
        case "Play":
            Application.LoadLevel ("SampleScene");
            break;
        case "shop":
            Application.OpenURL ("http://carrenta.by/");
            break;
            case "Help":
            Application.LoadLevel ("how to");
            break;
            case "Close":
            Application.LoadLevel ("Main");
            break;
        }
    }
}
