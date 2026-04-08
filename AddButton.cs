using System;
using UnityEngine;

public class AddButton : MonoBehaviour
{
    public GameObject mainPanel;
    public bool selectionPanelIsOpen = false;


    private void Update()
    {
        mainPanel.SetActive(selectionPanelIsOpen);
    }

    public void OpenMainPanel()
    {
        selectionPanelIsOpen = !selectionPanelIsOpen;
    }

    




}
