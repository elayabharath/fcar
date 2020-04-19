using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  public Transform cameraPos;
  public Car player;
  public Text score;
  void Start()
  {
    score.text = "";
  }

  void Update()
  {
    score.text = player.collisionCount.ToString();
    if (player.transform.position.y < 0)
    {
      score.transform.position = cameraPos.transform.position + new Vector3(100, 100, -300);
      score.text = "Over / " + player.collisionCount.ToString();
    }
  }
}
