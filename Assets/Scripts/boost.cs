using UnityEngine;

public class boost : MonoBehaviour
{
    public float boostForce = 2000f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        rb.AddForce(new Vector3(0, 0, boostForce), ForceMode.Impulse);
    }
}
