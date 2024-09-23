using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 2f;  
    
    private Rigidbody2D rb;

    private void Start() => rb = GetComponent<Rigidbody2D>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Jump();
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);  
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
