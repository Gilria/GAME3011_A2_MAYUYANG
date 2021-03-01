using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialPlate : MonoBehaviour
{
    public KeyCode A;
    public KeyCode D;

    public float turnspeed;
    public bool isRotate = true;
    

    private void Update()
    {
        if (Input.GetKeyDown(A))
        {
            transform.Rotate(Vector3.up, turnspeed);
            GameManager.currentAngle += 10;
            
        }
                
            


        if (Input.GetKeyDown(D))
        {
            transform.Rotate(Vector3.up, -turnspeed);
            GameManager.currentAngle -= 10;
        }
            

        if (Input.GetKeyDown(A) || Input.GetKeyDown(D))
        {
            isRotate = true;
        }
        else
            isRotate = false;

    }


}
