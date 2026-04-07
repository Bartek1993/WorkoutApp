using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PromptWindow : MonoBehaviour
{
    public string[] promptStrings = {"Please enter username", "WELOCME TO WORKOUT ADVENTURE!"};
    public GameObject promptWindowMain, promptWindowText;
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

    public IEnumerator DisplayPrompt(int promptID, int promptColorID)
    {
        promptText.text = promptStrings[promptID];
        promptWindowText.GetComponent<Image>().color = promptWindowColor[promptColorID];
        yield return new WaitForSeconds(5f);
        promptWindowMain.SetActive(false);
    }

    public void CloseWarningWindow()
    {
        StopAllCoroutines();
        promptWindowText.GetComponent<Image>().color = promptWindowColor[0];
        promptWindowMain.SetActive(false);
        
    }
}
