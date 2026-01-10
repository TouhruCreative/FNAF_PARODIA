using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinManager : MonoBehaviour
{
    public float time = 360f;
    public TMP_Text TextTime;

    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            UpdateTimer();
        } else
        {
            //win
            time = 0;
            UpdateTimer();
        }
    }
    void UpdateTimer()
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        TextTime.text = $"{6-minutes} PM";
    }
    void Win() { }
    void Lose() {  }
}
