using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleBehavior : MonoBehaviour
{
  public GameObject Monprefab;
  private Vector3 direction;
  private System.DateTime lastUpdate = System.DateTime.Now;

  public bool creator = true;

  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    // every 2 sec :  change direction
    if( System.DateTime.Now > this.lastUpdate ) {

    this.direction = new Vector3(
      UnityEngine.Random.Range(-1f, 1f),
      UnityEngine.Random.Range(-1f, 1f),
      0
    )*0.004f  ;

    this.lastUpdate = System.DateTime.Now.AddSeconds(1);
    }

    this.moveRandomly();

    if (Input.GetKeyDown(KeyCode.Space) && creator)
    {
      var instance = Instantiate(Monprefab);
    }
  }

  void moveRandomly()
  {
    this.transform.position += this.direction;
  }
}
