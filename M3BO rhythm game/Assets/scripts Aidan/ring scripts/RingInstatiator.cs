using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingInstatiator : MonoBehaviour
{
    
    private int currentRing = 0;
    [SerializeField] private GameObject ringprefag;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void instantiatering()
    {
        GameObject ring = Instantiate(ringprefag);
        ringlogger ringToLog = ring.GetComponent<ringlogger>();
        ringToLog.RingSetter(currentRing);
        currentRing++;
    }
}
