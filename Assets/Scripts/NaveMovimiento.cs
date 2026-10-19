using UnityEngine;

public class NaveMovimiento : MonoBehaviour
{
    public float fuerza = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            rb.AddForce(Vector2.left * fuerza, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            rb.AddForce(Vector2.right * fuerza, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        {
           rb.AddForce(Vector2.up * fuerza, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            rb.AddForce(Vector2.down * fuerza, ForceMode2D.Force);
        }
    }
}