using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    private TMP_Text scoreField;
    private int score = 0;
    void Start()
    {
        scoreField = GetComponent<TMP_Text>();
        score = 0;
        scoreField.text = "Score: " + score;
    }
    public void AddScore(int add)
    {
        score += add;
        scoreField.text = "Score: " + score;
    }
}
