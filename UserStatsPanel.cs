using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Application = UnityEngine.Application;
using Permission = UnityEngine.Android.Permission;

public class PermissionsRationaleDialog : MonoBehaviour
{
    const int kDialogWidth = 600;
    const int kDialogHeight = 350;
    private bool windowOpen = true;

    void DialogeDisplay(int windowID)
    {
        GUI.Label(new Rect(10, 20, kDialogWidth - 20, kDialogHeight - 50), "Permission to use ACTIVITY_RECOGNITION ?");
        GUI.Button(new Rect(10, kDialogHeight - 30, 100, 20), "No");
        if (GUI.Button(new Rect(kDialogWidth - 110, kDialogHeight - 30, 100, 20), "Yes"))
        {
#if PLATFORM_ANDROID
            Permission.RequestUserPermission(Permission.FineLocation);
#endif
            windowOpen = false;
        }
    }

    void OnGUI ()
    {
        if (windowOpen)
        {
            Rect rect = new Rect((Screen.width / 2) - (kDialogWidth / 2), (Screen.height / 2) - (kDialogHeight / 2), kDialogWidth, kDialogHeight);
            GUI.ModalWindow(0, rect, DialogeDisplay, "Permissions Request Dialog");
        }
    }
}



public class UserStatsPanel : MonoBehaviour
{
    public string bmiDescription, hipToWaistDescription;
    public string[] userDetails;
    public float userBMI, userHipToWaistRatio;
    public Text BMI,BMISECRIPTION ,HIPTOWAIST, USERNAME;
    public MasterScript masterScript;
    public Image bmiCircle, hipCircle;
    public float dailySteps;
    private GameObject _androidPermDialog;
    

    private void Start()
    {
        GetStats();
        //GetPermissionRequests();
    }

    private void GetPermissionRequests()
    {
        #if PLATFORM_ANDROID
        if (Application.platform == RuntimePlatform.Android)
        {
            Debug.Log("Target Platform is Android");
            if (!Permission.HasUserAuthorizedPermission("android.permission.ACTIVITY_RECOGNITION"))
            {
                Permission.RequestUserPermission("android.permission.ACTIVITY_RECOGNITION");
                _androidPermDialog = new GameObject();
            }
        }
        #endif
        else
        {
            Debug.Log("Target Platform is PC");
        }
    }

    private void OnGUI()
    {
        if (!Permission.HasUserAuthorizedPermission("android.permission.ACTIVITY_RECOGNITION"))
        {
            Permission.RequestUserPermission("android.permission.ACTIVITY_RECOGNITION");
            _androidPermDialog.AddComponent<PermissionsRationaleDialog>();
        }
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
        BMI.text = "BMI: " + userBMI.ToString("N1");
        HIPTOWAIST.text = "HTW RATIO:\n" + userHipToWaistRatio.ToString("N1");
        ////SET ADDITIONAL DESCRIPTION AND COLOR FOR BMI TEXT
        if (userBMI < 18.5f)
        {
            bmiDescription = "Underweight";
            bmiCircle.color = Color.blue;
        }
        else if (userBMI is >= 18.5f and < 24.9f)
        {
            bmiDescription = "Healthy Weight";
            bmiCircle.color = Color.green;
        }
        else if (userBMI is >= 25f and < 29.9f)
        {
            bmiDescription = "Overweight";
            bmiCircle.color = Color.orange;
        }
        else if (userBMI is >= 30f and < 34.9f)
        {
            bmiDescription = "Class 1 Obesity";
            bmiCircle.color = Color.orangeRed;
        }
        else if (userBMI is >= 35f and < 36.9f)
        {
            bmiDescription = "Class 2 Obesity";
            bmiCircle.color = Color.red;
        }
        else if (userBMI is >= 40)
        {
            bmiDescription = "Class 3 Obesity";
            bmiCircle.color = Color.darkRed;
        }
        
        BMISECRIPTION.text = bmiDescription;
        ////NEED TO MAKE VARIABLE IN PLAYER DATA FOR GENDER /////
        switch (PlayerPrefs.GetInt("Gender"))
        {
            case 0:
                if (userHipToWaistRatio <= 0.95 )
                {
                    hipCircle.color = Color.green;
                }
                else if (userHipToWaistRatio >= 0.96 &&  userHipToWaistRatio <= 1)
                {
                    hipCircle.color = Color.orange;
                }
                else if(userHipToWaistRatio > 1.01f)
                {
                    hipCircle.color = Color.red;
                }
                break;
            case 1:
                if (userHipToWaistRatio <= 0.80 )
                {
                    hipCircle.color = Color.green;
                }
                else if (userHipToWaistRatio >= 0.81 &&  userHipToWaistRatio <= 0.85)
                {
                    hipCircle.color = Color.orange;
                }
                else if(userHipToWaistRatio > 0.86f)
                {
                    hipCircle.color = Color.red;
                }
                break;
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

    /// <summary>
    /// GET USER STEP COUNT TODO
    /// </summary>
    private void GetDailySteps()
    {
        
        dailySteps = StepCounter.current.stepCounter.value;
    }
}
