using UnityEngine;
using UnityEngine.UI;

public class UpdateMeasurements : MonoBehaviour
{
    public MasterScript masterScript;
    public InputField [] inputFields;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        masterScript =  GetComponent<MasterScript>();
        foreach (InputField inputField in inputFields)
        {
            if (inputField.text == "")
            {
                float weight = PlayerPrefs.GetFloat("PlayerWeight");
                inputFields[0].text = weight.ToString("F");
                float height = PlayerPrefs.GetFloat("PlayerHeight");
                inputFields[1].text = height.ToString("F");
                float hip = PlayerPrefs.GetFloat("PlayerHipCirc");
                inputFields[2].text = hip.ToString("F");
                float waist = PlayerPrefs.GetFloat("PlayerWaistCirc");
                inputFields[3].text = waist.ToString("F");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetUpdate()
    {
        masterScript.playerData.UpdatePlayerData(float.Parse(inputFields[0].text), float.Parse(inputFields[1].text), 
            float.Parse(inputFields[2].text), float.Parse(inputFields[3].text));
    }

    public void ClearInputFields()
    {
        float weight = PlayerPrefs.GetFloat("PlayerWeight");
        inputFields[0].text = weight.ToString("F");
        float height = PlayerPrefs.GetFloat("PlayerHeight");
        inputFields[1].text = height.ToString("F");
        float hip = PlayerPrefs.GetFloat("PlayerHipCirc");
        inputFields[2].text = hip.ToString("F");
        float waist = PlayerPrefs.GetFloat("PlayerWaistCirc");
        inputFields[3].text = waist.ToString("F");
    }


}
