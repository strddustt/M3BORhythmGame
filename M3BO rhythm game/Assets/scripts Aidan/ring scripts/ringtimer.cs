using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringtimer : MonoBehaviour
{
    nocluewhattonamethisyet audiodata;
    // Start is called before the first frame update
    void Start()
    {
        audiodata = GetComponent<nocluewhattonamethisyet>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void somethingsomething()
    {
        float songlength = audiodata.getaudiodata();
        float totalbeats = (int)Mathf.Round(audiodata.bpm / songlength);
        float secondsperbeat = 60f / bpm;
    }
}
