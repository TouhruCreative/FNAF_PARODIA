using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRayCast : MonoBehaviour
{
    public GameObject DoorLeft;
    public GameObject DoorRight;
    public GameObject LightLeft;
    public GameObject LightRight;

    

    private bool isLeftDoorOpen = false;
    private bool isRightDoorOpen = false;
    private bool isLeftLightOn = false;
    private bool isRightLightOn = false;

    void RayCast(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit,50f))
        {
            if(hit.collider.tag == "button"){
                if (hit.collider.name == "LT button") 
                    isLeftDoorOpen = !isLeftDoorOpen;
                if (hit.collider.name == "RT button")
                    isRightDoorOpen = !isRightDoorOpen;
                    
                DoorLeft.SetActive(isLeftDoorOpen);
                DoorRight.SetActive(isRightDoorOpen);
                Debug.Log("Button Clicked");
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))//Light left
        {
            isLeftLightOn = !isLeftLightOn;
            if (isLeftLightOn) BatteryManager.energyFactor++;
            else { BatteryManager.energyFactor--; }
        }
        if (Input.GetKeyDown(KeyCode.A))//Door left
        { // !True = false
            isLeftDoorOpen = !isLeftDoorOpen;
            if (isLeftDoorOpen) BatteryManager.energyFactor++;
            else { BatteryManager.energyFactor--; }
        }
        if (Input.GetKeyDown(KeyCode.E))//Light right
        {
            isRightLightOn = !isRightLightOn;
            if (isRightLightOn) BatteryManager.energyFactor++;
            else { BatteryManager.energyFactor--; }
        }
        if (Input.GetKeyDown(KeyCode.D))//Door right
        {
            isRightDoorOpen = !isRightDoorOpen;
            if (isRightDoorOpen) BatteryManager.energyFactor++;
            else { BatteryManager.energyFactor--; }
        }
        //if(Input.GetMouseButtonDown(0))
        //   RayCast();
        DoorLeft.SetActive(isLeftDoorOpen);
        DoorRight.SetActive(isRightDoorOpen);
        LightLeft.SetActive(isLeftLightOn);
        LightRight.SetActive(isRightLightOn);
    }
}

/*
Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(1) && GUIUtility.hotControl == 0)//if Click
        { 
            if (Physics.Raycast(ray, out hit,50f))//if Raycast
            {
                if(hit.collider.tag != "cantShow"){//if can show object
                    Place = hit;
                    IInteractable interactable = hit.collider.GetComponent<IInteractable>();
                    TextUI.GetComponent<UnityEngine.UI.Text>().text=interactable.GetDescription();
                    SelObj.SetActive(true);
                }//end(if can show object)
                else{//else(if can show object)
                    TextUI.GetComponent<UnityEngine.UI.Text>().text="";
                    SelObj.SetActive(false);
                }//end else(if can show object)
            }//end(if Raycast)
            else{//else (if Raycast)
                TextUI.GetComponent<UnityEngine.UI.Text>().text="";
                SelObj.SetActive(false);
        }//end(else (if Raycast))
        }//end(if click)
        //SelObj
*/