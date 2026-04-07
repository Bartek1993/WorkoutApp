using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PromptWindow : MonoBehaviour
{
    public string[] promptStrings;
    public GameObject promptWindowMain, promptFrame, promptWindowText;
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

    public void DisplayPrompt(int promptID, int promptColorID, bool isWarning)
    {
        if (isWarning)
        {
            masterScript.audioManager.OnCancel();
        }
        else
        {
            masterScript.audioManager.OnApprove();
        }

        promptText.text = promptStrings[promptID];
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
}
