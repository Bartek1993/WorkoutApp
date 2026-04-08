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
    
    public Dropdown genderDropdown;
    
    void Start()
    {
        SetData();
        genderDropdown.value = 0;
        
    }

   

    /// <summary>
    /// CHECK FOR PRIMARY USER INFORMATION, IF NOT MAKE SOME
    /// </summary>
    public void SetData()
    {
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
}
