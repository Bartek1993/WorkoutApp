using System;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject userDetailsCanvas, mainCanvas, homepageCanvas;
    public int userDetailsComplete, userMenuTutorialComplete;
    public MasterScript masterScript;

    private void Start()
    {
        
        if (!PlayerPrefs.HasKey("userDetailsComplete"))
        {
            userDetailsComplete = 0;
            PlayerPrefs.SetInt("userDetailsComplete", userDetailsComplete);
        }
        else
        {
            userDetailsComplete = PlayerPrefs.GetInt("userDetailsComplete");
       
        }
        
        if (!PlayerPrefs.HasKey("userMenuTutorial"))
        {
            userMenuTutorialComplete = 0;
            PlayerPrefs.SetInt("userFirstTime", userMenuTutorialComplete);
        }
        else
        {
            userMenuTutorialComplete = PlayerPrefs.GetInt("userFirstTime");
        }

        if (PlayerPrefs.GetInt("userDetailsComplete") == 1)
        {
            StartGame();
        }
    }


    public void StartGame()
    {
    

        userDetailsCanvas.SetActive(false);
        mainCanvas.SetActive(true);
        if (userMenuTutorialComplete == 0)
        {
            masterScript.promptWindow.DisplayPrompt(2,2, false, true, 5f, 45);
            userMenuTutorialComplete = 1;
            PlayerPrefs.SetInt("userFirstTime", userMenuTutorialComplete);
        }
        
        
    }
}
