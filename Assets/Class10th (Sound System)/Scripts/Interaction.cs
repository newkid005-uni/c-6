using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] Ray ray;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDrawGizmos()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Gizmos.DrawRay(ray.origin, ray.direction * 100);
    }
}
