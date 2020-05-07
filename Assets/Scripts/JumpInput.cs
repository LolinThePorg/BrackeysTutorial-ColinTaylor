using UnityEngine;
using System.Collections;

public class JumpInput : MonoBehaviour
{
    public Rigidbody rb;
    [Range(1,10)]
    public float jumpForce;
    public bool onGround = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && onGround)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            onGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            onGround = true;
        }
    }
}
