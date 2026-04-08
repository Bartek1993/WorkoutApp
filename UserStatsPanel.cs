using System;
using UnityEngine;
using UnityEngine.UI;

public class UserStatsPanel : MonoBehaviour
{
    public string bmiDescription, hipToWaistDescription;
    public string[] userDetails;
    public float userBMI, userHipToWaistRatio;
    public Text BMI, HIPTOWAIST, USERNAME;
    public MasterScript masterScript;


    private void OnEnable()
    {
        GetStats();
    }
    

    /// <summary>
    /// GET USER DETAILS
    /// </summary>
    public void GetStats()
    {
        userDetails[0] = masterScript.playerData.GetPlayerName(); //// User Name N
        userDetails[1] = masterScript.playerData.GetAge().ToString(); //// User Age Y
        userDetails[2] =  masterScript.playerData.GetHeight().ToString(); //// User Height CM
        userDetails[3] = masterScript.playerData.GetWeight().ToString(); //// User Weight KG
        userDetails[4] = masterScript.playerData.GetHipCirc().ToString(); //// User Hip CM
        userDetails[5] = masterScript.playerData.GetWaistCirc().ToString(); //// User Waist CM
        USERNAME.text = userDetails[0];
        SetMeasurments();


    }

    /// <summary>
    /// BMI AND HIPS TO WAIST RATIO PROPERTIES
    /// </summary>
    private void SetMeasurments()
    {
        userBMI = GetBmi(float.Parse(userDetails[3]), float.Parse(userDetails[2])/100);
        userHipToWaistRatio= GetHipToWaistRatio(float.Parse(userDetails[4]), float.Parse(userDetails[5]));
        BMI.text = "BMI: " + bmiDescription+ "\n" + userBMI.ToString("N1");
        HIPTOWAIST.text = "HIP TO WAIST RATIO: \n" + userHipToWaistRatio.ToString("N1");
        ////SET ADDITIONAL DESCRIPTION AND COLOR FOR BMI TEXT
        if (userBMI < 18.5f)
        {
            bmiDescription = "Underweight";
            BMI.color = Color.blue;
        }
        else if (userBMI is >= 18.5f and < 24.9f)
        {
            bmiDescription = "Healthy Weight";
            BMI.color = Color.green;
        }
        else if (userBMI is >= 25f and < 29.9f)
        {
            bmiDescription = "Overweight";
            BMI.color = Color.orange;
        }
        else if (userBMI is >= 30f and < 34.9f)
        {
            bmiDescription = "Class 1 Obesity";
            BMI.color = Color.orangeRed;
        }
        else if (userBMI is >= 35f and < 36.9f)
        {
            bmiDescription = "Class 2 Obesity";
            BMI.color = Color.red;
        }
        else if (userBMI is >= 40)
        {
            bmiDescription = "Class 3 Obesity";
            BMI.color = Color.darkRed;
        }
    }

    /// <summary>
    /// CALCULATE BMI
    /// </summary>
    /// <param name="weight"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    private float GetBmi(float weight, float height)
    {
        
        float heightmult = height * height;
        return weight / heightmult;
    }

    /// <summary>
    /// CALCULATE HIP TO WAIST RATIO
    /// </summary>
    /// <param name="hip"></param>
    /// <param name="waist"></param>
    /// <returns></returns>
    private float GetHipToWaistRatio(float hip, float waist)
    {
        return hip / waist;
    }
}
