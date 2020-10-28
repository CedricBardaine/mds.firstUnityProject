using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
  private Rigidbody2D rigidbody2D;
  private SpriteRenderer sRdr;
  private bool colored = false;


  void Start()
  {
    rigidbody2D = GetComponent<Rigidbody2D>();
    sRdr = GetComponent<SpriteRenderer>();
  }

  void FixedUpdate()
  {
    if(colored) {
      // sRdr.color = Color.green;
      colored = false;
    }
  }

  private void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.layer == LayerMask.NameToLayer("Goal"))
    {
      sRdr.color = Color.red;
      colored = true ;
    }
  }
}
