using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  private int scoreP1 = 0;
  public TextMesh textScoreP1;
  private int scoreP2 = 0;
  public TextMesh textScoreP2;

  public GameObject theBall;
  public GameObject P1;
  public GameObject P2;

  [Tooltip("This is the text to display anything we want during the game.")]

  public TextMesh textForAnything;

  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("start game");
  }

  // Update is called once per frame
  void Update() { }

  public void goalP1()
  {
    this.scoreP1++;
    this.textScoreP1.text = this.scoreP1.ToString();
    this.reInitBallAndPlayerPosition();

    if (this.scoreP1 >= 3)
      this.endGame(1);
  }
  public void goalP2()
  {
    this.scoreP2++;
    this.textScoreP2.text = this.scoreP2.ToString();
    this.reInitBallAndPlayerPosition();

    if (this.scoreP2 >= 3)
      this.endGame(2);

  }
  private void reInitBallAndPlayerPosition()
  {
    this.theBall.transform.position = new Vector3(0, 0, 0);
    this.P1.transform.position = new Vector3(-1, 0, 0);
    this.P2.transform.position = new Vector3(1, 0, 0);
  }

  private void endGame(int i)
  {
    this.textForAnything.text = "Player " + i + " win !!";

    this.P1.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    this.P2.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
  }
}
