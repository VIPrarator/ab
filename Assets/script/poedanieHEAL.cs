using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poedanieHEAL : MonoBehaviour
{
    public float scaleFactor = 1.5f;
    public Sprite heal;
    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("clown"))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.gravityScale = 2f;
            Destroy(gameObject);
        }
        if (collision.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }
    }
}
