using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    private bool isPaused = false;
    public Image pauseImage;
    public Image MUSICimg;
    public Sprite pausee;
    public Sprite play;
    public Sprite musicON;
    public Sprite musicOFF;
    public GameObject MENUpanel;
    public Button musicToggleButton;
    public AudioSource music;
   

    private bool isMusicOn = true;
    bool pausebool = false;


    private void Start()
    {
       
    }
    public void panelOFF()
    {
        if (pausebool == false)
        {
            MENUpanel.SetActive(false);
            Time.timeScale = 1f;
            pauseImage.sprite = pausee;
            pausebool = true;
        }

    }
    public void panelOFON()
    {
        if(pausebool == true)
        {
            MENUpanel.SetActive(true);
            Time.timeScale = 0f;
            pauseImage.sprite = play;
            pausebool = false;
        }

    }
    public void panelON()
    {
        MENUpanel.SetActive(true);
        Time.timeScale = 0f;
        pauseImage.sprite = play;

    }
    public void ToggleMusic()
    {
        if (isMusicOn)
        {
            music.Stop();
            isMusicOn = false;
            MUSICimg.sprite = musicOFF;
        }
        else
        {
            music.Play();
            isMusicOn = true;
            MUSICimg.sprite = musicON;
        }
    }

    public void menu()
    {
        Application.LoadLevel("MENU");
    }
   
}
