using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaboom : MonoBehaviour
{
    public float scaleFactor = 1.5f;
    public Sprite boom;
 
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("clown"))
        {
         
            Destroy(gameObject);
        
        }
        if (collision.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }
    }
}
