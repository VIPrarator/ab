using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PANELPODCKAZKA : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject playerOBJ;
    public GameObject buttomOBJ;
    public GameObject MusicBOT;
    public GameObject text1;
    public GameObject text2;
    void Start()
    {
        Time.timeScale = 0f;
    }
    
    
    public void dontpause()
    {
        Time.timeScale = 1f;
        settingsPanel.SetActive(false);
        playerOBJ.SetActive(true);
        MusicBOT.SetActive(true);
        text1.SetActive(true);
        text2.SetActive(true);


        buttomOBJ.gameObject.SetActive(true);
    }
}
