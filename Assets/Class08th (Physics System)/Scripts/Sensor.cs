using Unity.VisualScripting;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("OntriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("OnTriggerExit");
    }
}
