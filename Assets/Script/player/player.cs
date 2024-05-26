using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed = 4f;
    public Rigidbody2D  RB_2D;

    void Start()
    {
        RB_2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    public void playerMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        RB_2D.velocity = new Vector2(moveHorizontal * speed, RB_2D.velocity.y);
    }
}
