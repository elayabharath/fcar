using UnityEngine;

public class Car : MonoBehaviour
{

    public Rigidbody rb;
    public int collisionCount = -1;

    void Start()
    {
        rb.AddForce(0, 200, 0);
    }

    void FixedUpdate()
    {
        // Seems Oculus inputs are usually fetched in  Update, not Fixed Update
        // FixedUpdate I think seems to be a more reliable source of deltaTime
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-10000 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(10000 * Time.deltaTime, 0, 0);
        }
        // This is the unity input capture.
        //float horizontalInput = Input.GetAxis("Horizontal");

        // The Update is needed for OVR input capture.
        // Seems it can be avoided if we use OVRManager
        OVRInput.Update();
        OVRInput.Controller ctrl = OVRInput.GetConnectedControllers();     

        Vector2 horizontalAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

        bool xPressed = OVRInput.GetUp(OVRInput.RawButton.X);
        if (xPressed)
        {
            Debug.Log("X Pressed"); // Never triggered.
        }        

        if (horizontalAxis.x < -0.5f)
        {
            rb.AddForce(-10000 * Time.deltaTime, 0, 0);
        }

        if (horizontalAxis.x > 0.5f)
        {
            rb.AddForce(10000 * Time.deltaTime, 0, 0);
        }


    }

    private void OnCollisionEnter(Collision other)
    {
        collisionCount += 1;
    }
}
