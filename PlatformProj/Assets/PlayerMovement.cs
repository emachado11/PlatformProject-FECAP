using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Public vars
    public float speed;

    //Serialized vars
    [SerializeField]bool isGrounded;
    
    //Private vars
    Rigidbody2D rb;
    Transform groundCheck;
    float horizontalInput;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * (speed * 100) * Time.fixedDeltaTime, 0);
    }
}
