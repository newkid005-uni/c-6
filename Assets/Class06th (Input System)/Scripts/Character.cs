using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Character : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed;

    void Start()
    {
        transform.position = new Vector3(0,0,-10);
    }


    void Update()
    {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical"));

        //Time.deltaTime
        //이전 프레임에서 현재 프레임까지 걸린 시간입니다.

        direction.Normalize();

        transform.position += direction * Time.deltaTime * speed;
    }
}
