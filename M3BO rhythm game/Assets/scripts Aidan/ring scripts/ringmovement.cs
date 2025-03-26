using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringmovement : MonoBehaviour
{
    private RingRenderer ring;
    private float radius = 10f;
    // Start is called before the first frame update
    void Start()
    {
        ring = GetComponent<RingRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        ring.radius = this.radius;
        radius -= 0.05f;
        ring.DrawRing();
        if (radius <= 0)
        {
            Destroy(ring.gameObject);
        }
    }
}
