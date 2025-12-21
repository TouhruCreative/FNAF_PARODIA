using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabController : MonoBehaviour
{
    public GameObject minimap;
    public GameObject mainCamera;
    public GameObject testCamera;

    private bool isTabOpen = false;

    void Open() 
    {
        minimap.SetActive(true);
        mainCamera.SetActive(false);
        testCamera.SetActive(true);
        isTabOpen = true;
    }

    void Close() 
    {
        minimap.SetActive(false);
        mainCamera.SetActive(true);
        testCamera.SetActive(false);
        isTabOpen = false;
    }

    public void tabButton() 
    {
        if (!isTabOpen) Open();
        else Close();
    }
}
