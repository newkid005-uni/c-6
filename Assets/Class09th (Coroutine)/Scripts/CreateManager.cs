using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    
    [SerializeField] GameObject elemental;
    [SerializeField] List<GameObject> monsters;
    [SerializeField] WaitForSeconds wait;
    [SerializeField] int index = 0;

    void Start()
    {
        wait = new WaitForSeconds(5.0f);

        for(int i = 0; i < 5; i++)
        {
            GameObject clone = Instantiate(elemental,transform);
            clone.transform.position = new Vector3(i * 1.5f - 3, 0, 0);
            clone.SetActive(false);
            monsters.Add(clone);

        }
        StartCoroutine(Coroutine(wait));
    }

    IEnumerator Coroutine(WaitForSeconds wait)
    {
        Debug.Log("Start Coroutine");

        yield return wait;
        monsters[index].SetActive(true);

        Debug.Log("Stop Coroutine");

        if(++index < monsters.Count)
        {
            StartCoroutine(Coroutine(wait));
        }
    }
}
