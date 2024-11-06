using UnityEngine;

public class TopDownPlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of player movement
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from the player
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right arrow
        movement.y = Input.GetAxisRaw("Vertical");   // W/S or Up/Down arrow
    }

    void FixedUpdate()
    {
        // Move the player by changing the Rigidbody2D position
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
