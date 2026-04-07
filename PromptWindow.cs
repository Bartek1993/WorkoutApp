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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayPrompt(int promptID, int promptColorID, bool isWarning, bool isTimed, float timeToClose, int fontSize)
    {
        promptText.fontSize = fontSize;
        if (isWarning)
        {
            masterScript.audioManager.OnCancel();
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
        promptFrame.GetComponent<Image>().color = promptWindowColor[promptColorID];
        promptWindowText.GetComponent<Image>().color = promptWindowColor[promptColorID];

        

    }

    public void CloseWarningWindow(bool isWarning)
    {
        StopAllCoroutines();
        promptFrame.GetComponent<Image>().color = promptWindowColor[0];
        promptWindowText.GetComponent<Image>().color = promptWindowColor[0];
        promptWindowMain.SetActive(false);
        
        
    }

    public IEnumerator TimedPrompt(float timeToClose)
    {
        yield return new WaitForSeconds(timeToClose);
        promptWindowMain.SetActive(false);
    }
}
