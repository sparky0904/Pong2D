using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;

    private float speed = 10.0f;
    private Rigidbody2D RB;

    // Use this for initialization
    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(moveUp))
        {
            RB.velocity = new Vector2(0.0f, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            RB.velocity = new Vector2(0.0f, speed * -1);
        }
        else
        {
            RB.velocity = new Vector2(0.0f, 0.0f);
        }
    }
}