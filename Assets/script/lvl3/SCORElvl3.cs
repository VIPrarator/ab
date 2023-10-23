using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORElvl3 : MonoBehaviour
{
    public Text textComponent;
    public int score = 30;
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
                Application.LoadLevel("WINSCENES3");
            }
        }
    }
}
