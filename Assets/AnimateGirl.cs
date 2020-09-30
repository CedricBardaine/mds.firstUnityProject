using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimateGirl : MonoBehaviour {

    Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            animator.SetFloat("speed", 2f);
        } else {
            animator.SetFloat("speed", 0f);
        }
    }
}