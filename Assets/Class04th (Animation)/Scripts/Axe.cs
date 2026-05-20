using System;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public int count;
    public float proficiency;

    public void Attack(int count)
    {
        this.count += count;

        if (this.count % 10 == 0)
        {
            Debug.Log("Critical!!");
        }
    }

    public void Defend(int a)
    {
        Debug.Log("Defend");
    }

    public void Throw(float experience)
    {
        proficiency += experience;

        if (proficiency >= 100)
        {
            Debug.Log("스킬숙련 성공");
        }
        else
        {
            Debug.Log("스킬숙련도 : " + proficiency + "%");
        }
    }

}
