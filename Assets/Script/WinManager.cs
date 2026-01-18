using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
            time = 0;
            Win();
            UpdateTimer();
        }
    }
    void UpdateTimer()
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        TextTime.text = $"{6-minutes} PM";
    }
    void Win() { SceneManager.LoadScene("WinScene"); }
    public void Lose() { SceneManager.LoadScene("LoseScene"); }
}
