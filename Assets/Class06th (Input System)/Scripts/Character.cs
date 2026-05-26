using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Character : MonoBehaviour
{
    public Vector3 direction;

    void Start()
    {
        transform.position = new Vector3(0,0,-10);
    }


    void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));

        transform.position += direction;
    }
}
