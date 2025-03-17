using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierRotation : MonoBehaviour
{
    [SerializeField] private int RotationSpeed;
    void FixedUpdate()
    {
        Rotation();
    }
    void Rotation()
    {
        if(Input.GetKey(KeyCode.A) ||  Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward* RotationSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back* RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, 0, +180);
        }
    }
}
