using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D RB;
    public float speed = 5.0f;

    // Use this for initialization
    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();

        // Set direciton of ball at beginning
        int randomNumber = Random.Range(0, 10);
        if (randomNumber <= 5)
        {
            Debug.Log("Shoot Right");
            RB.AddForce(new Vector2(80, 10));
        }
        else
        {
            Debug.Log("Shoot Left");
            RB.AddForce(new Vector2(-80, 10));
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            float velY = RB.velocity.y;
            velY = (velY / 2) + (collision.rigidbody.velocity.y / 3);

            RB.velocity = new Vector2(RB.velocity.x, velY);
        }
    }
}