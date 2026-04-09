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
        ClearInputFields();
    }
    public void GetUpdate()
    {
        masterScript.playerData.UpdatePlayerData(float.Parse(inputFields[0].text), float.Parse(inputFields[1].text), 
            float.Parse(inputFields[2].text), float.Parse(inputFields[3].text), float.Parse(inputFields[4].text),
            float.Parse(inputFields[5].text), float.Parse(inputFields[6].text), float.Parse(inputFields[7].text),
            float.Parse(inputFields[8].text), float.Parse(inputFields[9].text), float.Parse(inputFields[10].text),
            float.Parse(inputFields[11].text), float.Parse(inputFields[12].text));
    }

    public void ClearInputFields()
    {
        //// PRIMARY ////
        float weight = PlayerPrefs.GetFloat("PlayerWeight");
        inputFields[0].text = weight.ToString("F");
        float height = PlayerPrefs.GetFloat("PlayerHeight");
        inputFields[1].text = height.ToString("F");
        float hip = PlayerPrefs.GetFloat("PlayerHipCirc");
        inputFields[2].text = hip.ToString("F");
        float waist = PlayerPrefs.GetFloat("PlayerWaistCirc");
        inputFields[3].text = waist.ToString("F");
        //// SECONDARY ////
        float neck = PlayerPrefs.GetFloat("PlayerNeckCirc");
        inputFields[4].text = neck.ToString("F");
        float leftArm = PlayerPrefs.GetFloat("PlayerLeftArmCirc");
        inputFields[5].text = leftArm.ToString("F");
        float rightArm = PlayerPrefs.GetFloat("PlayerRightArmCirc");
        inputFields[6].text = rightArm.ToString("F");
        float leftQuip = PlayerPrefs.GetFloat("PlayerLeftQuadricepCirc");
        inputFields[7].text = leftQuip.ToString("F");
        float rightQuip = PlayerPrefs.GetFloat("PlayerRightQuadricepCirc");
        inputFields[8].text = rightQuip.ToString("F");
        float leftCalv = PlayerPrefs.GetFloat("PlayerLeftCalvCirc");
        inputFields[9].text = leftCalv.ToString("F");
        float rightCalv = PlayerPrefs.GetFloat("PlayerRightCalvCirc");
        inputFields[10].text = rightCalv.ToString("F");
        float chest = PlayerPrefs.GetFloat("PlayerChestCirc");
        inputFields[11].text = chest.ToString("F");
        float shoulder = PlayerPrefs.GetFloat("PlayerShoulderCirc");
        inputFields[12].text = shoulder.ToString("F");
    }


}
