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

}
