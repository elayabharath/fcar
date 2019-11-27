using UnityEngine;
using System.Collections.Generic;
public class CreateObstacles : MonoBehaviour
{
  public Material myMaterial;
  List<GameObject> cubes = new List<GameObject>();

  void FixedUpdate()
  {
    if (cubes.Count < 10)
    {
      addNewCube();
    }

    foreach (var cube in cubes)
    {
      cube.GetComponent<Rigidbody>().AddForce(0, 0, -500 * Time.deltaTime);
      if (cube.transform.position.z < -60 || cube.transform.transform.position.y < -10)
      {
        cube.transform.position = new Vector3(r(-7, 7), r(5, 15), r(0, 50));
        cube.transform.localScale = new Vector3(r(1, 3), 1, 1);
        cube.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
      }
    }
  }
  int r(int min, int max)
  {
    System.Random random = new System.Random();
    return random.Next(min, max);
  }


  void addNewCube()
  {
    var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    cube.transform.position = new Vector3(r(-7, 7), r(5, 15), r(0, 50));
    cube.transform.localScale = new Vector3(r(1, 3), 1, 1);
    cube.AddComponent<Rigidbody>();
    cube.GetComponent<MeshRenderer>().material = myMaterial;
    cube.GetComponent<Rigidbody>().useGravity = true;

    cubes.Add(cube);
  }
}
