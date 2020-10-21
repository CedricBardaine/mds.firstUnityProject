using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleBehavior : MonoBehaviour
{
  public GameObject Monprefab;

  void Start()
  {
    InvokeRepeating("moveRandomly", 0, 2);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      var instance = Instantiate(Monprefab);
    }
  }

  void moveRandomly()
  {
    this.transform.position += new Vector3(
      UnityEngine.Random.Range(-1f, 1f),
      UnityEngine.Random.Range(-1f, 1f),
      UnityEngine.Random.Range(-1f, 1f)
    );
  }
}
