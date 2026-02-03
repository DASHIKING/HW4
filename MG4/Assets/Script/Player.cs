using UnityEngine;
using System;

public class Bird : MonoBehaviour
{
    public float jumpForce = 5f;
    public AudioSource audioSource;
    public AudioClip flapSound;
    public AudioClip hitSound;

    private Rigidbody2D rb;

    public static event Action OnScore;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            audioSource.PlayOneShot(flapSound);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Pipe"))
        {
            audioSource.PlayOneShot(hitSound);
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Score"))
        {
            OnScore?.Invoke();
        }
    }
}
