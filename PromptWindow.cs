using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PromptWindow : MonoBehaviour
{
    public string[] promptStrings;
    public GameObject promptWindowMain, promptFrame, promptWindowText;
    public GameObject closeButton;
    public Text promptText;
    public Color [] promptWindowColor;
    public MasterScript masterScript;

    /// <summary>
    /// CALL THIS METHOD TO DISPLAY WINDOW 
    /// </summary>
    /// <param name="promptID"> choose text from array of strings</param>
    /// <param name="promptColorID"> choose color of the window from array of colors</param>
    /// <param name="isWarning"> </param>
    /// <param name="isTimed"> if it is timed it coroutine within the method will be called and window will be closed after user
    /// specified amount of time</param>
    /// <param name="timeToClose"></param>
    /// <param name="fontSize">set font size of the message</param>
    public void DisplayPrompt(int promptID, int promptColorID, bool isWarning, bool isTimed, float timeToClose, int fontSize)
    {
      
        if (isWarning)
        {
        
            closeButton.SetActive(true);
        }
        else
        {
            masterScript.audioManager.OnApprove();
            closeButton.SetActive(false);
        }

        if (isTimed)
        {
            closeButton.SetActive(false);
            StartCoroutine(nameof(TimedPrompt),timeToClose);
        }

        promptText.text = promptStrings[promptID];
        promptText.fontSize = fontSize;
        promptFrame.GetComponent<Image>().color = promptWindowColor[promptColorID];
        promptWindowText.GetComponent<Image>().color = promptWindowColor[promptColorID];

        

    }

    public void CloseWarningWindow()
    {
        StopAllCoroutines();
        promptFrame.GetComponent<Image>().color = promptWindowColor[0];
        promptWindowText.GetComponent<Image>().color = promptWindowColor[0];
        promptWindowMain.SetActive(false);
        
        
    }

    public IEnumerator TimedPrompt(float timeToClose)
    {
        yield return new WaitForSecondsRealtime(timeToClose);
        promptWindowMain.SetActive(false);
    }
}
