using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public enum LastMovement
{
  RIGHT, LEFT
}

[RequireComponent(typeof(SpritesheetAnimator))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class AnimateGirlSpritesheet : MonoBehaviour
{
  SpritesheetAnimator animator;
  SpriteRenderer spriteRenderer;
  LastMovement lastMove;
  float movingSpeed = 0.02f;

      private Rigidbody2D rigidbody2D;


  void Start() //or Awake() ?
  {
    animator = GetComponent<SpritesheetAnimator>();
    spriteRenderer = GetComponent<SpriteRenderer>();
            rigidbody2D = GetComponent<Rigidbody2D>();

  }
  void FixedUpdate()
  {
    bool moved = false;

    if (Input.GetKey(KeyCode.Space))
    {
      this.moveRoll();
      moved = true;
    }
    else
    {
      if (Input.GetKey(KeyCode.RightArrow))
      {
        this.moveRight();
        moved = true;
      }
      else if (Input.GetKey(KeyCode.LeftArrow))
      {
        this.moveLeft();
        moved = true;
      }

      if (Input.GetKey(KeyCode.UpArrow))
      {
        this.moveUp();
        moved = true;
      }
      else if (Input.GetKey(KeyCode.DownArrow))
      {
        this.moveDown();
        moved = true;
      }

    }

    if (!moved)
    {
      animator.Play(Anims.Iddle);
      moved = false;
    }
  }

  void moveRoll()
  {
    animator.Play(Anims.Roll);
    if (lastMove == LastMovement.LEFT)
    {
      animator.transform.position += Vector3.left * this.movingSpeed;
    }
    else
    {
      animator.transform.position += Vector3.right * this.movingSpeed;
    }
  }
  void moveRight()
  {
    animator.Play(Anims.Run);
    if (lastMove == LastMovement.LEFT)
    {
      spriteRenderer.flipX = !spriteRenderer.flipX;
    }
    lastMove = LastMovement.RIGHT;
    animator.transform.position += Vector3.right * this.movingSpeed;
  }
  void moveLeft()
  {
    animator.Play(Anims.Run);
    if (lastMove == LastMovement.RIGHT)
    {
      spriteRenderer.flipX = !spriteRenderer.flipX;
    }
    lastMove = LastMovement.LEFT;
    animator.transform.position += Vector3.left * this.movingSpeed;
  }
  void moveUp()
  {
    animator.Play(Anims.Run);
    animator.transform.position += Vector3.up * this.movingSpeed;
  }
  void moveDown()
  {
    animator.Play(Anims.Run);
    animator.transform.position += Vector3.down * this.movingSpeed;
  }
}