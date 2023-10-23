using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HEALTH4 : MonoBehaviour
{
    public Text textComponent;
    public int health = 3;
    void Start()
    {
        textComponent.text = $"ЖИЗНИ: " + health.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("heal"))
        {
            ++health;
            textComponent.text = $"ЖИЗНИ: " + health.ToString();
        }
        if (collision.CompareTag("enemy"))
        {
            --health;
            //Debug.Log(health);
            if (health >= 3)
            {
                textComponent.text = $"ЖИЗНИ: " + health.ToString();
            }
            else if (health == 2)
            {
                textComponent.text = $"ЖИЗНИ: " + health.ToString();
            }
            else if (health == 1)
            {
                textComponent.text = $"ЖИЗНИ: " + health.ToString();
            }
            else if (health == 0)
            {
                Application.LoadLevel("DEATHSCENES4");
            }
        }
    }
}
