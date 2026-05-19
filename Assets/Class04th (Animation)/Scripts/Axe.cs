using System;
using UnityEngine;

public class Axe : MonoBehaviour
{
    int attackTimes = 0;

    public void Attack(int count)
    {
        if (count++ > 10)
        {
            Debug.Log("Critical!!");
        }
    }

    public void Defend(int a)
    {
        Debug.Log("Defend");
    }

    public void Throw(float a)
    {
        Debug.Log("Throw");
    }

}
