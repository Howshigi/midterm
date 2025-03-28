using UnityEngine;

public class FrictionController : MonoBehaviour
{
    public float friction = 3f; // ค่าความเสียดทาน
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionStay(Collision collision)
    {
        // ลดความเร็วของ Rigidbody ตามแรงเสียดทาน
        rb.velocity *= (1 - friction * Time.deltaTime);
    }
}