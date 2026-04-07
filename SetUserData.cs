using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SetUserData : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerUserData;
    public Text[] userInputFields;
    
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
        foreach (Text text in userInputFields)
        {
            if (text.text != "")
            {
                playerUserData.SavePlayerData(userInputFields[0].text,int.Parse(userInputFields[1].text), 
                    float.Parse(userInputFields[2].text), float.Parse(userInputFields[3].text),
                    float.Parse(userInputFields[4].text), float.Parse(userInputFields[5].text));
            }
            else
            {
                Debug.Log("Please enter a valid input");
            }
        }

      
    }



}
