using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  public Transform player;
  void Update()
  {
    transform.position = player.position + new Vector3(0, 1, -5);
  }
}
