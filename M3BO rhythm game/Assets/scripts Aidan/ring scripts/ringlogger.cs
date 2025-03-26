using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringlogger : MonoBehaviour
{
    private int currentring;
    public int Currentring { get { return currentring; } private set { currentring = value; } }
    public void RingSetter(int value)
    {
        Currentring = value;
    }
}
