using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHits : MonoBehaviour
{
    public KeepScore KeepScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "note")
        {

            KeepScore.SubtractScore(1);
            Destroy(collision.gameObject);
        }
        
    }
}
