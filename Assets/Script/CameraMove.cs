using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float rotatinonSpeed = 50f;
    public float maxAngle = 60f;
    public float gap = 0.25f;
    
    private float currentRotation = 0f;
    
    float GetInputDirection(){
        float x = Input.mousePosition.x;
        float width = Screen.width;
        if(x<width*gap) return -1f;
        else if(x>width*(1-gap)) return 1f;
        return 0f;
    }

    void Update()
    {
        float direction = GetInputDirection();
        if(direction != 0f){
            currentRotation += direction * rotatinonSpeed * Time.deltaTime;
            currentRotation = Mathf.Clamp(currentRotation, -maxAngle, maxAngle);
            transform.localEulerAngles = new Vector3(0f, currentRotation, 0f);
        }
    }
}

