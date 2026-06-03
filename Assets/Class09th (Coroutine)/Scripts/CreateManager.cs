using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    
    [SerializeField] GameObject elemental;
    [SerializeField] List<GameObject> monsters;
    [SerializeField] int index = 0;
    [SerializeField] float time = 0;
    void Start()
    {
        
        for(int i = 0; i<5;i++)
        {
            GameObject clone = Instantiate(elemental,transform);
            clone.transform.position = new Vector3(i * 1.5f - 3, 0, 0);
            clone.SetActive(false);
            monsters.Add(clone);

        }
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        Debug.Log("Start Coroutine");

        yield return new WaitForSeconds(5.0f);

        Debug.Log("Stop Coroutine");
    }
}
