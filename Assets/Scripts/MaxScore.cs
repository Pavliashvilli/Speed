using System.Collections;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class MaxScore : MonoBehaviour
{
    public int score;
    public UnityEngine.UI.Text scoreText;
    
    void Start()
    {
        scoreText = gameObject.GetComponent <UnityEngine.UI.Text> ();
       // score =  = PlayerPrefs.GetInt ("Score");
       // DisplayScore();
        StartCoroutine(CheckChangeInScore());
    }

private IEnumerator CheckChangeInScore(){
   // int newScore = PlayerPrefs.GetInt ("Score");
    while(true){
            int newScore = PlayerPrefs.GetInt ("Score");
            if(newScore!=score){
                score = newScore;
                DisplayScore();
            }
            yield return new WaitForSeconds(1f);
    }
}

private void DisplayScore(){
    scoreText.text = score.ToString();
}
   
}
