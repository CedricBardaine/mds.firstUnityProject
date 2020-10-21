using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleBehavior : MonoBehaviour {


  // Start is called before the first frame update
  void Start() {
    InvokeRepeating("moveRandomly", 0, 2);
  }

  // Update is called once per frame
  void Update(){
  }

  void moveRandomly() {
    this.transform.position += new Vector3(
      UnityEngine.Random.Range(-1f,1f),
      UnityEngine.Random.Range(-1f,1f),
      UnityEngine.Random.Range(-1f,1f)
    );

  }
}
