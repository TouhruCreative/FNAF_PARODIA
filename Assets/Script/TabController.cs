using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabController : MonoBehaviour
{
    public GameObject minimap;
    public GameObject mainCamera;
    public GameObject[] Cameras; // Список камер на сцене

    private bool isTabOpen = false;
    private int currentActiveCameras = 0; // Номер текущая активная камера
    
    void Open() 
    {
        minimap.SetActive(true);
        mainCamera.SetActive(false);
        Cameras[currentActiveCameras].SetActive(true); // Активация текущей камеры
        isTabOpen = true;
        BatteryManager.energyFactor++;
    }

    void Close() 
    {
        minimap.SetActive(false);
        mainCamera.SetActive(true);
        Cameras[currentActiveCameras].SetActive(false); // Деактивация текущей камеры
        isTabOpen = false;
        BatteryManager.energyFactor--;
    }

    public void SwitchActiveCamera(int idCamera) // Метод смены текущей активной камеры
    {
        Cameras[currentActiveCameras].SetActive(false);
        currentActiveCameras = idCamera;
        Cameras[currentActiveCameras].SetActive(true);
    }

    public void tabButton() 
    {
        if (!isTabOpen && BatteryManager.currentBattery>0)
        {
            Open();
        }
        else
        {
            Close();
        }    
     }
    void Update()
    {
        if (BatteryManager.currentBattery <= 0)
            Close();
    }

}
