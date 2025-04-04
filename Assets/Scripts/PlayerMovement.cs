using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sideWaysForce = 500f;
   

    // Update is called once per frame
    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0 , 0 , forwardForce * Time.deltaTime);

        if(Input.GetKey("d")) {
            rb.AddForce(sideWaysForce * Time.deltaTime ,0,0 , ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")) {
            rb.AddForce(-sideWaysForce * Time.deltaTime ,0,0 , ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindAnyObjectByType<GameManager>()?.EndGame();
        }
    }
}
