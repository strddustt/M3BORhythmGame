using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform endPosition;
    // Start
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPosition.position, speed * Time.deltaTime);
        if(transform.position == endPosition.position)
        {
            Destroy(gameObject);
        }
    }
}
