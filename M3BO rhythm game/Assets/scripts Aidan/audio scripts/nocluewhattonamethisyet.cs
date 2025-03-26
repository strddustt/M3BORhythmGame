using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class nocluewhattonamethisyet : MonoBehaviour
{
    public int bpm;
    AudioSource source;
    private float songlength;
    AudioClip clip;
    private void Start()
    {
        source = GetComponent<AudioSource>();
        clip = source.clip;
        getaudiodata();
    }
    public float getaudiodata()
    {
        songlength = clip.length;
        Debug.Log(songlength);
        return songlength;
    }
}
