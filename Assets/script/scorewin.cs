using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorewin : MonoBehaviour
{
    public Text textComponent;
    public int score = 10;
    void Start()
    {
        textComponent.text = $"ОЧКОВ ОСТАЛОСЬ: " + score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("friend"))
        {
            --score;
            textComponent.text = $"ОЧКОВ ОСТАЛОСЬ: " + score.ToString();
            if (score == 0)
            {
                Application.LoadLevel("WINSCENES1");
            }
        }
    }
}
