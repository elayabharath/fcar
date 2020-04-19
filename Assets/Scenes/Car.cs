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
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      rb.AddForce(-10000 * Time.deltaTime, 0, 0);
    }

    if (Input.GetKey(KeyCode.RightArrow))
    {
      rb.AddForce(10000 * Time.deltaTime, 0, 0);
    }
  }

  private void OnCollisionEnter(Collision other)
  {
    collisionCount += 1;
  }
}
