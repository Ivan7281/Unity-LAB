using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuTimer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
 
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float elapsedTime = Time.time - startTime;

        string minutes = ((int)elapsedTime / 60).ToString("00");
        string seconds = (elapsedTime % 60).ToString("00");

        timerText.text = $"Timer: {minutes}:{seconds}";
    }
}
