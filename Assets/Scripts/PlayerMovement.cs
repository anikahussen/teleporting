using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; //
    public float forwardForce = 1000f; //forward/back
    public float sidewaysForce = 1000f; //left/right



    private void FixedUpdate()
    {
        // AddForce(float x, float y, float z, ForceMode mode = ForceMode.Force);
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime); //forward 
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime); //back
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0); //right
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0); //left
        }
    }


}
