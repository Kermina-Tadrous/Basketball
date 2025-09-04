using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 StartPosition;
    private float movement;
    void Start()
    {
        StartPosition = transform.position;
    }
    // Update is called once per frame
        public void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = StartPosition;
    }
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, movement * speed);
    }
}