using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryManager : MonoBehaviour
{
    public static float currentBattery;
    public static int energyFactor = 0;
    const float maxBattery = 100;
    
    void Start()
    {
        currentBattery = maxBattery;
    }

    void Update()
    {
        if (currentBattery > 0)
            currentBattery -= energyFactor * Time.deltaTime;
        else 
            currentBattery = 0;
        Debug.Log(currentBattery);
    }

}
