using UnityEngine;

public class AddButton : MonoBehaviour
{
    public GameObject mainPanel, addExercisePanel;
    public void OpenMainPanel()
    {
        mainPanel.SetActive(true);
    }

    public void AddExercisePanel()
    {
        addExercisePanel.SetActive(true);
        mainPanel.SetActive(false);
    }




}
