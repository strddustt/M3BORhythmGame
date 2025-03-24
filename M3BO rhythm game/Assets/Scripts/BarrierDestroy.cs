using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierDestroy : MonoBehaviour
{
    private KeepScore scoreScript;
    private void Start()
    {
        scoreScript = FindObjectOfType<KeepScore>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "note")
        {
            scoreScript.AddScore(1);
            Destroy(collision.gameObject);
        }
    }
}
