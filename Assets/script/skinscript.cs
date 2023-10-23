using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinscript : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    int number = 1;
    

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        number = menumanager.skinNUMBER;
        if (number == 1)
        {
            spriteRenderer.sprite = sprite1;
            transform.localScale = new Vector3(12f, 12f, 100f);
        }
        else if (number == 2)
        {
            spriteRenderer.sprite = sprite2;
            transform.localScale = new Vector3(20f, 17f, 100f);
        }
        else if (number == 3)
        {
            spriteRenderer.sprite = sprite3;
            transform.localScale = new Vector3(12f, 12f, 100f);
        }
        else if (number == 4)
        {
            spriteRenderer.sprite = sprite4;
            transform.localScale = new Vector3(12f, 12f, 100f);
        }
        else if (number == 5)
        {
            spriteRenderer.sprite = sprite5;
            transform.localScale = new Vector3(12f, 12f, 100f);
        }
    }
}
