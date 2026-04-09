using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMethods : MonoBehaviour
{
    MasterScript masterScript;

    private void Start()
    {
        masterScript = GetComponent<MasterScript>();
    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
        
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
        
    }

    public void SaveMeasurementData()
    {
        masterScript.updateMeasurements.GetUpdate();
        masterScript.userStatsPanel.GetStats();
        
    }

    public void ClearMeasurementData()
    {
        masterScript.updateMeasurements.ClearInputFields();
        masterScript.userStatsPanel.GetStats();
    }
    
    public void GetInformation(int buttonID)
    {
        masterScript.promptWindow.promptWindowMain.SetActive(true);
        if (buttonID == 0)
        {
            masterScript.promptWindow.DisplayPrompt(4,0, true, false,
                0, 65);
        }
        if (buttonID == 1)
        {
            masterScript.promptWindow.DisplayPrompt(5,0, true, false,
                0, 65);
        }

        
    }

}
