using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float horizontalInput;
    public float verticalInput;
    public float jumpSpeed;
    private float minSpeed = 15;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector2.up* jumpSpeed, ForceMode2D.Impulse);
        }
    }
    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        rigidBody.AddForce(Vector2.right * horizontalInput* minSpeed);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }
        if (col.gameObject.CompareTag("Win"))
        {
            Debug.Log("You Won");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ladder"))
        {
            Debug.Log("Ladder");
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector2.up * verticalInput);
        }
    }

}
