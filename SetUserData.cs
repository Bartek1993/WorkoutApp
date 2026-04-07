using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SetUserData : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerUserData;
    public InputField [] userInputFields;
    public MasterScript masterScript;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveUserData()
    {
        foreach (InputField text in userInputFields)
        {
            if (text.text != "" && userInputFields[0].text != "")
            {
                playerUserData.SavePlayerData(userInputFields[0].text,int.Parse(userInputFields[1].text), 
                    float.Parse(userInputFields[2].text), float.Parse(userInputFields[3].text),
                    float.Parse(userInputFields[4].text), float.Parse(userInputFields[5].text));
                Debug.Log("Data saved");
                masterScript.promptWindow.promptWindowMain.SetActive(true);
                StartCoroutine(masterScript.promptWindow.DisplayPrompt(1,2));
                
            }
            else
            {
                masterScript.promptWindow.promptWindowMain.SetActive(true);
                StartCoroutine(masterScript.promptWindow.DisplayPrompt(0,1));
            }
        }

      
    }



}
