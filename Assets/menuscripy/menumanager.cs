using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject MENUpanel;
    public GameObject lvla;
    public GameObject gamePanel;
    public static int skinNUMBER = 1;
    public void PlayGame()
    {
        gamePanel.SetActive(true);
       // Application.LoadLevel("GAME");
    }
    public void lvl1()
    {
        Application.LoadLevel("lvl1");
    }
    public void lvl2()
    {
        Application.LoadLevel("lvl2");
    }
    public void lvl3()
    {
        Application.LoadLevel("lvl3");
    }
    public void lvl4()
    {
        Application.LoadLevel("lvl4");
    }
    public void lvl5()
    {
        Application.LoadLevel("lvl5");
    }
    public void lvl6easy()
    {
        Application.LoadLevel("lvl6");
    }
    public void Panellvl6()
    {
        lvla.SetActive(true);
    }
    public void menu()
    {
        Application.LoadLevel("MENU");
    }
    public void nextlvl1()
    {
        Application.LoadLevel("lvl2");
    }
    public void nextlvl2()
    {
        Application.LoadLevel("lvl3");
    }
    public void nextlvl3()
    {
        Application.LoadLevel("lvl4");
    }
    public void nextlvl4()
    {
        Application.LoadLevel("lvl5");
    }
    public void ExitLeavle()
    {
        gamePanel.SetActive(false);
    }
    
    public void ExitGame() 
    {
        Application.Quit();
    }
    public void SettingsPanel()
    {
        settingsPanel.SetActive(true);
    }
    public void Exit()
    {
        settingsPanel.SetActive(false);
    }
    public void skin1()
    {    
        skinNUMBER = 1;
        settingsPanel.SetActive(false);
    }
    public void skin2()
    {
        skinNUMBER = 2;
        settingsPanel.SetActive(false);
    }
    public void skin3()
    {
        skinNUMBER = 3;
        settingsPanel.SetActive(false);
    }
    public void skin4()
    {
        skinNUMBER = 4;
        settingsPanel.SetActive(false);
    }
    public void skin5()
    {
        skinNUMBER = 5;
        settingsPanel.SetActive(false);
    }

}
