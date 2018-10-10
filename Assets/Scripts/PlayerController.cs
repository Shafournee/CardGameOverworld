using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum moveDirection { up, down, left, right, none }

public class PlayerController : MonoBehaviour {

    // -------- Components ---------
    Rigidbody2D rigidBody;
    // -------- Components ---------

    // -------- Inspector Variables --------
    [SerializeField] float speed;
    // -------- Inspector Variables --------

    // -------- Private Variables ----------
    KeyCode up = KeyCode.W;
    KeyCode down = KeyCode.S;
    KeyCode left = KeyCode.A;
    KeyCode right = KeyCode.D;

    moveDirection leftRight;
    moveDirection upDown;
    // -------- Private Variables ----------


	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    private void FixedUpdate()
    {
        
    }

    void SetMoveDirection()
    {
        if (Input.GetKey(up))
        {
            upDown = moveDirection.up;
        }
        else if (Input.GetKey(down))
        {
            upDown = moveDirection.down;
        }
        else
        {
            upDown = moveDirection.none;
        }

        if (Input.GetKey(right))
        {
            leftRight = moveDirection.right;
        }
        else if (Input.GetKey(left))
        {
            leftRight = moveDirection.left;
        }
        else
        {
            leftRight = moveDirection.none;
        }
    }

    void Movement()
    {
        if (upDown == moveDirection.up)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, speed);
        }
        else if (upDown == moveDirection.down)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, -speed);
        }
        else
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0f);
        }

        if (leftRight == moveDirection.right)
        {
            rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);
        }
        else if (leftRight == moveDirection.left)
        {
            rigidBody.velocity = new Vector2(-speed, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = new Vector2(0f, rigidBody.velocity.y);
        }
    }
}
