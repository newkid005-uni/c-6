using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    Vector3 direction;
    [SerializeField] float speed;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        //rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        direction.Normalize();
    }

    private void FixedUpdate()
    {

        //ForceMode.Force(지속적인 힘)
        //입력한 힘(F)을 물체의 무게(m)으로 나눈 값에 물리 프레임 시간(t)을 곱한 만큼
        //속도가 점진적으로 증가합니다.

        //ForceMode.Acceleration(지속적인 가속도)
        //물체의 무게(m)를 연산에서 제외하며, 입력한 값 자체를 가속도로 지정하여,
        //매 프레임마다 시간(t)을 곱한 만큼의 속도로 증가합니다.

        //ForceMode.Impulse(순간적인 힘)
        //단 한 번의 프레임 만에 입력한 충격량(I)을 무게(m)로 나눈 만큼 속도를
        //즉시 변화시키는 힘입니다.

        //ForceMode.VelocityChange(순간적인 속도 변화)
        //무게(m)과 시간(t)을 모두 무시하며, 입력한 벡터 값 자체가 객체의 다음
        //프레임 속도 변화량이 되는 것입니다.

        rigidbody.AddForce(direction * speed,ForceMode.Force);
    }
}
