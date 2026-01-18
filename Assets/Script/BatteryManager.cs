using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BatteryManager : MonoBehaviour
{
    public static float currentBattery;
    public static int energyFactor = 0;
    const float maxBattery = 100;

    public TMP_Text batteryText;

    void Start()
    {
        currentBattery = maxBattery;
    }

    void Update()
    {

        if (currentBattery > 0)
            currentBattery -= energyFactor * Time.deltaTime;
        else
        {
            currentBattery = 0;
            //Lose();
        }
        batteryText.text = ( (int)currentBattery ).ToString() + '%';
    }

}
