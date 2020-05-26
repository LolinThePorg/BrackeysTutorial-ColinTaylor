using System.Xml.Serialization;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float touchingBoostPad = 1f;

    // Use FixedUpdate for physics 
    void FixedUpdate()
    {
        //if (collision.gameObject.name == "Boost pad")
        //{
        //    touchingBoostPad = 40000;
        //}
        //adding forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime + touchingBoostPad);
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
       
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    
}
