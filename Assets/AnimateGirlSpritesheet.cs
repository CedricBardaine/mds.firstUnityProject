using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public enum LastMovement {
    RIGHT, LEFT
}

[RequireComponent(typeof(SpritesheetAnimator))]
[RequireComponent(typeof(SpriteRenderer))]
public class AnimateGirlSpritesheet : MonoBehaviour {
    SpritesheetAnimator animator;
    SpriteRenderer spriteRenderer;
    LastMovement lastMove ; 
    float movingSpeed = 0.02f; 
    
    void Start() {
        animator = GetComponent<SpritesheetAnimator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            animator.Play(Anims.Run);
            if(lastMove == LastMovement.LEFT) {
                spriteRenderer.flipX = !spriteRenderer.flipX ;
            }
            lastMove = LastMovement.RIGHT;

            animator.transform.position += Vector3.right * this.movingSpeed;
        } 
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            animator.Play(Anims.Run);
            if(lastMove == LastMovement.RIGHT) {
                spriteRenderer.flipX = !spriteRenderer.flipX ;
            }
            lastMove = LastMovement.LEFT;

            animator.transform.position += Vector3.left * this.movingSpeed;
        } 
        else if (Input.GetKey(KeyCode.UpArrow)) {
            animator.Play(Anims.Run);
            animator.transform.position += Vector3.up * this.movingSpeed;
        } 
        else if (Input.GetKey(KeyCode.DownArrow)) {
            animator.Play(Anims.Run);
            animator.transform.position += Vector3.down * this.movingSpeed;
        } 
        else if (Input.GetKey(KeyCode.Space)) {
            animator.Play(Anims.Roll);
            if(lastMove == LastMovement.LEFT) {
            animator.transform.position += Vector3.left * this.movingSpeed;
            } else {
            animator.transform.position += Vector3.right * this.movingSpeed;
            }
        } else {
            animator.Play(Anims.Iddle);
        }
    
    }
}