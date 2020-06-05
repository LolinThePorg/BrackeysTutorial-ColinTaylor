using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float boost;
    public float boostTimer;
    public bool boosting;

    private void Start()
    {
        boost = forwardForce;
        boostTimer = 0;
        boosting = false;
    }
    // Use FixedUpdate for physics 
    void FixedUpdate()
    {
        //if (collision.gameObject.name == "Boost pad")
        //{
        //    touchingBoostPad = 40000;
        //}
        //adding forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
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

        if (boosting)
        {
            boostTimer += Time.deltaTime;
            if (boostTimer >= 2)
            {
                forwardForce = 4300;
                boostTimer = 0;
                boosting = false;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "speedBoost")
        {
            boosting = true;
            forwardForce = 8000;
        }
    }


}
