using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData: MonoBehaviour
{
    private string playerName {get; set; }
    private int playerAge {get; set; }
    private float playerHeight {get; set; }
    private float playerWeight {get; set; }
    private float playerHipCirc {get; set; }
    private float playerWaistCirc {get; set; }
    
    private float neckCirc {get; set; }
    private float leftArmCirc {get; set; }
    private float rightArmCirc {get; set; }
    private float leftQuadricepCirc {get; set; }
    private float rightQuadricepCirc {get; set; }
    private float leftCalvCirc {get; set; }
    private float rightCalvCirc {get; set; }
    private float chestCirc {get; set; }
    private float shoulderCirc {get; set; }
    
    public Dropdown genderDropdown;
    
    void Start()
    {
        SetData();
        genderDropdown.value = 0;
        
    }

   

    /// <summary>
    /// CHECK FOR PRIMARY AND SECONDARY USER INFORMATION, IF NOT MAKE SOME
    /// </summary>
    public void SetData()
    {
        ///// PRIMARY PLAYER DETAILS ////
        if (!PlayerPrefs.HasKey("PlayerName"))
        {
            playerName = "User";
            PlayerPrefs.SetString("PlayerName", "User");
        }
        else
        {
            playerName = PlayerPrefs.GetString("PlayerName");
        }

        if (!PlayerPrefs.HasKey("PlayerAge"))
        {
            playerAge = 25;
            PlayerPrefs.SetInt("PlayerAge", playerAge);
        }
        else
        {
            playerAge = PlayerPrefs.GetInt("PlayerAge");
        }

        if (!PlayerPrefs.HasKey("PlayerHeight"))
        {
            playerHeight = 176;
            PlayerPrefs.SetFloat("PlayerHeight", playerHeight);
        }
        else
        {
            playerHeight = PlayerPrefs.GetFloat("PlayerHeight");
        }

        if (!PlayerPrefs.HasKey("PlayerWeight"))
        {
            playerWeight = 78;
            PlayerPrefs.SetFloat("PlayerWeight", playerWeight);
        }
        else
        {
            playerWeight = PlayerPrefs.GetFloat("PlayerWeight");
        }

        if (!PlayerPrefs.HasKey("PlayerHipCirc"))
        {
            playerHipCirc = 90;
            PlayerPrefs.SetFloat("PlayerHipCirc", playerHipCirc);
        }
        else
        {
            playerHipCirc = PlayerPrefs.GetFloat("PlayerHipCirc");
        }

        if (!PlayerPrefs.HasKey("PlayerWaistCirc"))
        {
            playerWaistCirc = 87;
            PlayerPrefs.SetFloat("PlayerWaistCirc", playerWaistCirc);
        }
        else
        {
            playerWaistCirc = PlayerPrefs.GetFloat("PlayerWaistCirc");
        }

        if (!PlayerPrefs.HasKey("Gender"))
        {
            PlayerPrefs.SetInt("Gender", 0);
        }
        
        ///// SECONDARY PLAYER DATA ////
        
        if(!PlayerPrefs.HasKey("PlayerNeckCirc"))
        {
            neckCirc = 35;
            PlayerPrefs.SetFloat("PlayerNeckCirc", neckCirc);
        }
        else
        {
            neckCirc = PlayerPrefs.GetFloat("PlayerNeckCirc");
        }

        if (!PlayerPrefs.HasKey("PlayerLeftArmCirc"))
        {
            leftArmCirc = 35;
            PlayerPrefs.SetFloat("PlayerLeftArmCirc", leftArmCirc);
        }
        else
        {
            leftArmCirc = PlayerPrefs.GetFloat("PlayerLeftArmCirc");
        }

        if (!PlayerPrefs.HasKey("PlayerRightArmCirc"))
        {
            rightArmCirc = 35;
            PlayerPrefs.SetFloat("PlayerRightArmCirc", rightArmCirc);
        }
        else
        {
            rightArmCirc = PlayerPrefs.GetFloat("PlayerRightArmCirc");
        }

        if (!PlayerPrefs.HasKey("PlayerLeftQuadricepCirc"))
        {
            leftQuadricepCirc = 75;
            PlayerPrefs.SetFloat("PlayerLeftQuadricepCirc", leftQuadricepCirc);
        }
        else
        {
            leftQuadricepCirc = PlayerPrefs.GetFloat("PlayerLeftQuadricepCirc");
        }

        if (!PlayerPrefs.HasKey("PlayerRightQuadricepCirc"))
        {
            rightQuadricepCirc = 75;
            PlayerPrefs.SetFloat("PlayerRightQuadricepCirc", rightQuadricepCirc);
        }
        else
        {
            rightQuadricepCirc = PlayerPrefs.GetFloat("PlayerRightQuadricepCirc");
        }

        if (!PlayerPrefs.HasKey("PlayerLeftCalvCirc"))
        {
            leftCalvCirc = 35;
            PlayerPrefs.SetFloat("PlayerLeftCalvCirc", leftCalvCirc);
        }
        else
        {
            leftCalvCirc = PlayerPrefs.GetFloat("PlayerLeftCalvCirc");
        }

        if (!PlayerPrefs.HasKey("PlayerRightCalvCirc"))
        {
            rightCalvCirc = 35;
            PlayerPrefs.SetFloat("PlayerRightCalvCirc", rightCalvCirc);
        }
        else
        {
            rightCalvCirc = PlayerPrefs.GetFloat("PlayerRightCalvCirc");
        }

        if (!PlayerPrefs.HasKey("PlayerChestCirc"))
        {
            chestCirc = 75;
            PlayerPrefs.SetFloat("PlayerChestCirc", chestCirc);
        }
        else
        {
            chestCirc = PlayerPrefs.GetFloat("PlayerChestCirc");
        }

        if (!PlayerPrefs.HasKey("PlayerShoulderCirc"))
        {
            shoulderCirc = 85;
            PlayerPrefs.SetFloat("PlayerShoulderCirc", shoulderCirc);
        }
        else
        {
            shoulderCirc = PlayerPrefs.GetFloat("PlayerShoulderCirc");
        }
    }

    /// <summary>
    /// CALL THIS METHOD WHEN YOU WANT TO SAVE PRIMARY USER DETAILS
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    /// <param name="height"></param>
    /// <param name="weight"></param>
    /// <param name="hipCirc"></param>
    /// <param name="waistCirc"></param>
    public void SavePlayerData(string name, int age, float height, float weight, float hipCirc, float waistCirc)
    {
        playerName = name;
        playerAge = age;
        playerHeight = height;
        playerWeight = weight;
        playerHipCirc = hipCirc;
        playerWaistCirc = waistCirc;
        PlayerPrefs.SetString("PlayerName", name );
        PlayerPrefs.SetInt("PlayerAge", age);
        PlayerPrefs.SetFloat("PlayerHeight", height);
        PlayerPrefs.SetFloat("PlayerWeight", weight);
        PlayerPrefs.SetFloat("PlayerHipCirc", hipCirc);
        PlayerPrefs.SetFloat("PlayerWaistCirc", waistCirc);
    }

    public void SetGenderDropdown()
    {
        if (genderDropdown.value == 0)
        {
            Debug.Log("You Choose Male");
            PlayerPrefs.SetInt("Gender", 0);
        }
        else if (genderDropdown.value == 1)
        {
            Debug.Log("You Choose Female");
            PlayerPrefs.SetInt("Gender", 1);
        }
    }

    /// <summary>
    /// GET USER DATA
    /// </summary>
    /// <returns></returns>
    public int GetAge()
    {
        return playerAge;
    }

    public float GetHeight()
    {
        return playerHeight;
    }

    public float GetWeight()
    {
        return playerWeight;
    }

    public float GetHipCirc()
    {
        return playerHipCirc;
    }

    public float GetWaistCirc()
    {
        return playerWaistCirc;
    }

    public string GetPlayerName()
    {
        return playerName;
    }

    public void UpdatePlayerData(float weight, float height, float hipCirc, float waistCirc, 
        float neck, float leftArm, float rightArm, float leftQuip, float rightQuip, float leftCalv, float rightCalv,
        float chest, float shoulder)
    {
        //// PRIMARY INFO
        playerWeight = weight;
        playerHeight = height;
        playerHipCirc = hipCirc;
        playerWaistCirc = waistCirc;
        PlayerPrefs.SetFloat("PlayerHeight", playerHeight);
        PlayerPrefs.SetFloat("PlayerWeight", playerWeight);
        PlayerPrefs.SetFloat("PlayerHipCirc", playerHipCirc);
        PlayerPrefs.SetFloat("PlayerWaistCirc", playerWaistCirc);
        //// SECONDARY
        neckCirc = neck;
        leftArmCirc = leftArm;
        rightArmCirc = rightArm;
        leftQuadricepCirc = leftQuip;
        rightQuadricepCirc = rightQuip;
        leftCalvCirc = leftCalv;
        rightCalvCirc = rightCalv;
        chestCirc = chest;
        shoulderCirc = shoulder;
        PlayerPrefs.SetFloat("PlayerNeckCirc", neckCirc);
        PlayerPrefs.SetFloat("PlayerLeftArmCirc", leftArmCirc);
        PlayerPrefs.SetFloat("PlayerRightArmCirc", rightArmCirc);
        PlayerPrefs.SetFloat("PlayerLeftQuadricepCirc", leftQuadricepCirc);
        PlayerPrefs.SetFloat("PlayerRightQuadricepCirc", rightQuadricepCirc);
        PlayerPrefs.SetFloat("PlayerLeftCalvCirc", leftCalvCirc);
        PlayerPrefs.SetFloat("PlayerRightCalvCirc", rightCalvCirc);
        PlayerPrefs.SetFloat("PlayerChestCirc", chestCirc);
        PlayerPrefs.SetFloat("PlayerShoulderCirc", shoulderCirc);

        
    }
}
