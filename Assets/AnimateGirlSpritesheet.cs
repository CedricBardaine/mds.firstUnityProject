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
        } 
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            animator.Play(Anims.Run);
            if(lastMove == LastMovement.RIGHT) {
                spriteRenderer.flipX = !spriteRenderer.flipX ;
            }
            lastMove = LastMovement.LEFT;
        } 
        
        else if (Input.GetKey(KeyCode.DownArrow)) {
            animator.Play(Anims.Roll);
        } else {
            animator.Play(Anims.Iddle);
        }
    
    }
}