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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        userInputFields[0].text = "Username";
        userInputFields[1].text = "00";
        userInputFields[2].text = "00";
        userInputFields[3].text = "00";
        userInputFields[4].text = "00";
        userInputFields[5].text = "00";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveUserData()
    {
        if (userInputFields[0].text.Length > 5)
        {
            playerUserData.SavePlayerData(userInputFields[0].text,int.Parse(userInputFields[1].text), 
                float.Parse(userInputFields[2].text), float.Parse(userInputFields[3].text),
                float.Parse(userInputFields[4].text), float.Parse(userInputFields[5].text));
            Debug.Log("Data saved");
            masterScript.promptWindow.promptWindowMain.SetActive(true);
            masterScript.promptWindow.DisplayPrompt(1,2, false);
            StartCoroutine(nameof(LoadMenu));
        }
        else
        {
            masterScript.promptWindow.promptWindowMain.SetActive(true);
            masterScript.promptWindow.DisplayPrompt(0,1, true);
        }

      
    }

    public IEnumerator LoadMenu()
    {
        
        yield return new WaitForSecondsRealtime(1);
        masterScript.promptWindow.CloseWarningWindow();
        
    }



}
