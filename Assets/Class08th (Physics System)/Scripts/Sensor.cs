using Unity.VisualScripting;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    [SerializeField] Controller controller;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.transform.gameObject.name);

        controller = other.GetComponent<Controller>();

        if(controller != null )
        {
            controller.Soar();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("OntriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
