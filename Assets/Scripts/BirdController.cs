using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public GameManager gameManager;
    public int speed = 100;
    private Rigidbody2D rb;
    private AudioSource jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * speed;
            jump.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
