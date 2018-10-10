using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // -------- Components ---------
    Rigidbody2D rigidBody;
    // -------- Components ---------

    // -------- Inspector Variables --------
    float speed;
    // -------- Inspector Variables --------

    // -------- Private Variables ----------
    KeyCode up = KeyCode.W;
    KeyCode down = KeyCode.S;
    KeyCode left = KeyCode.A;
    KeyCode right = KeyCode.D;
    // -------- Private Variables ----------


	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Movement()
    {
        if(Input.GetKey(up))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, speed);
        }
        else if (Input.GetKey(down))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, -speed);
        }

        if (Input.GetKey(right))
        {
            rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);
        }
        else if (Input.GetKey(down))
        {
            rigidBody.velocity = new Vector2(-speed, rigidBody.velocity.y);
        }
    }
}
