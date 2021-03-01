using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearing_aid : MonoBehaviour
{


    private float deltaX;
    private float deltaY;

    private void Update()
    {
        
        deltaX = transform.position.x + Input.GetAxis("Mouse X");
        deltaY = transform.position.y + Input.GetAxis("Mouse Y");
        if(deltaX >= -0.87 && deltaX <= 2.95 && deltaY >= -2.23 && deltaY <= 2.93)
        {
            transform.position = new Vector3(transform.position.x + Input.GetAxis("Mouse X"), transform.position.y + Input.GetAxis("Mouse Y"), transform.position.z);
        }

       
        


    }



}
