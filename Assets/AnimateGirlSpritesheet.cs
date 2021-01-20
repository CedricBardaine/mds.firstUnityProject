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
  float movingSpeed = 1.5f;

  public bool p2 = false;

  private Rigidbody2D rigidbody2D;


  void Start() //or Awake() ?
  {
    animator = GetComponent<SpritesheetAnimator>();
    spriteRenderer = GetComponent<SpriteRenderer>();
    rigidbody2D = GetComponent<Rigidbody2D>();

    if (p2) spriteRenderer.color = new Color(0.68f, 0.85f, 0.9f);
    else spriteRenderer.color = new Color(1.0f, 0.5f, 0.0f);
  }
  void FixedUpdate()
  {
    bool moved = false;
    Vector3 move = Vector3.zero;

    if (p2)
    {
      if (Input.GetKey(KeyCode.Space))
      {
        move += this.moveRoll();
        moved = true;
      }
      else
      {
        if (Input.GetKey(KeyCode.RightArrow))
        {
          move += this.moveRight();
          moved = true;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
          move += this.moveLeft();
          moved = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
          move += this.moveUp();
          moved = true;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
          move += this.moveDown();
          moved = true;
        }
      }
    }
    else
    {
      if (Input.GetKey(KeyCode.E))
      {
        move += this.moveRoll();
        moved = true;
      }
      else
      {
        if (Input.GetKey(KeyCode.D))
        {
          move += this.moveRight();
          moved = true;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
          move += this.moveLeft();
          moved = true;
        }
        if (Input.GetKey(KeyCode.Z))
        {
          move += this.moveUp();
          moved = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
          move += this.moveDown();
          moved = true;
        }
      }
    }

    if (!moved)
    {
      animator.Play(Anims.Iddle);
      moved = false;
    }

    rigidbody2D.velocity = move;
  }

  Vector3 moveRoll()
  {
    animator.Play(Anims.Roll);
    if (lastMove == LastMovement.LEFT)
    {
      return Vector3.left * (this.movingSpeed * 0.8f);
    }
    else
    {
      return Vector3.right * (this.movingSpeed * 0.8f);
    }
  }
  Vector3 moveRight()
  {
    animator.Play(Anims.Run);
    if (lastMove == LastMovement.LEFT)
    {
      spriteRenderer.flipX = !spriteRenderer.flipX;
    }
    lastMove = LastMovement.RIGHT;
    return Vector3.right * this.movingSpeed;
  }
  Vector3 moveLeft()
  {
    animator.Play(Anims.Run);
    if (lastMove == LastMovement.RIGHT)
    {
      spriteRenderer.flipX = !spriteRenderer.flipX;
    }
    lastMove = LastMovement.LEFT;
    return Vector3.left * this.movingSpeed;
  }
  Vector3 moveUp()
  {
    animator.Play(Anims.Run);
    return Vector3.up * this.movingSpeed;
  }
  Vector3 moveDown()
  {
    animator.Play(Anims.Run);
    return Vector3.down * this.movingSpeed;
  }
}