﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    public void RestartLevel(){
       Player.alive = true ;
       MoveObjects.speed = 2.0f;
       SceneManager.LoadScene("Main");
   }
}
