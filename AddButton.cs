using UnityEngine;

public class AddButton : MonoBehaviour
{
    public GameObject mainPanel;
    public bool isMainPanelOpen = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainPanel.SetActive(isMainPanelOpen);
    }


    public void OpenMainPanel()
    {
        isMainPanelOpen = !isMainPanelOpen;
    }

}
