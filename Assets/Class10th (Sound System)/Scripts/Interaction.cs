using System;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;
    [SerializeField] float distance = 100.0f;
    [SerializeField] AudioSource sound;
    [SerializeField] LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, distance, layerMask))
            {
                Debug.Log(raycastHit.collider.gameObject.name);

                
                sound = raycastHit.collider.gameObject.GetComponent<AudioSource>();

                if(!sound.isPlaying)
                {
                    sound.Play();
                }
                

            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(ray.origin, ray.direction * distance);
    }


}
