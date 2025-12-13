using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRayCast : MonoBehaviour
{
    void RayCast(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit,50f))
        {
            if(hit.collider.tag == "button"){
                Debug.Log("Button Clicked");
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayCast();
        }
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