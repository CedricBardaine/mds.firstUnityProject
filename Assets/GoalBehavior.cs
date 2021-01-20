using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
  public GameManager theGameManager;

  [Tooltip("'1' or '2'")]
  public int playerNumber;
  // Start is called before the first frame update
  void Start()
  {
    if (this.playerNumber != 1 && this.playerNumber != 2)
      throw new System.Exception();
  }

  // Update is called once per frame
  void Update()
  {

  }

  private void OnTriggerEnter2D(Collider2D other)
  {

    if (other.gameObject.tag == "Ball")
      switch (this.playerNumber)
      {
        case 1:
          this.theGameManager.goalP1();
          break;
        case 2:
          this.theGameManager.goalP2();
          break;
        default:
          break;
      }
    else
    {
      Debug.Log("Ca ne compte pas comme un point !");
    }
  }
}
