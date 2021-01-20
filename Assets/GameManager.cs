﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  private int scoreP1 = 0;
  public TextMesh textScoreP1;
  private int scoreP2 = 0;
  public TextMesh textScoreP2;

  public GameObject theBall;


  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("start game");
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void goalP1()
  {
    this.scoreP1++;
    this.textScoreP1.text = this.scoreP1.ToString();
    this.reInitBallPosition();
  }
  public void goalP2()
  {
    this.scoreP2++;
    this.textScoreP2.text = this.scoreP2.ToString();
    this.reInitBallPosition();
  }
  private void reInitBallPosition()
  {
    this.theBall.transform.position = new Vector3(0, 0, 0);
  }


}