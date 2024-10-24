using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime;


    private void Update()
    {
        NewGame();

        if (Input.GetKeyDown(KeyCode.N))
        {
            NewGame();
        }
  
    }

    private void NewGame()
    {
        
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);


        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
