using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounceForce;
    public Rigidbody rb;
    public JumpInput jumpInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter()
    {
        rb.AddForce(new Vector3(0, bounceForce, 0), ForceMode.Impulse);
        jumpInput.onGround = false;
    }
}
