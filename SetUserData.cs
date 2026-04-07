using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SetUserData : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerUserData;
    public InputField [] userInputFields;
    public MasterScript masterScript;
    public Button submitButton;

    /// <summary>
    /// WORK IN PROGRESS
    /// </summary>
    public void SaveUserData()
    {
        if (userInputFields[0].text.Length is >= 5 and <= 15)
        {
            playerUserData.SavePlayerData(userInputFields[0].text,int.Parse(userInputFields[1].text), 
                float.Parse(userInputFields[2].text), float.Parse(userInputFields[3].text),
                float.Parse(userInputFields[4].text), float.Parse(userInputFields[5].text));
            Debug.Log("Data saved");
            masterScript.promptWindow.promptWindowMain.SetActive(true);
            masterScript.promptWindow.DisplayPrompt(1,2, true, false,0, 25);
            PlayerPrefs.SetInt("userDetailsComplete",1);
            masterScript.canvasManager.StartGame();
        }
        else
        {
            masterScript.promptWindow.promptWindowMain.SetActive(true);
            masterScript.promptWindow.DisplayPrompt(0,1, true,false,0,75);
        }

      
    }

    





}
