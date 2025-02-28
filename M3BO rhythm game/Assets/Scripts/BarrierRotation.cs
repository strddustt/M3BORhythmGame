using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierRotation : MonoBehaviour
{
    public int RotationSpeed = 10;
    void Update()
    {
        Rotation();
    }
    void Rotation()
    {
        if(Input.GetKey(KeyCode.A) ||  Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward* RotationSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back* RotationSpeed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, 0, +180);
        }
    }
}
