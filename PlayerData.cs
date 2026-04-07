using UnityEngine;

public class PlayerData: MonoBehaviour
{
    string PlayerName {get; set; }
    int PlayerAge {get; set; }
    float PlayerHeight {get; set; }
    float PlayerWeight {get; set; }
    float PlayerHipCirc {get; set; }
    float PlayerWaistCirc {get; set; }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavePlayerData(string name, int age, float height, float weight, float hipCirc, float waistCirc)
    {
        PlayerName = name;
        PlayerAge = age;
        PlayerHeight = height;
        PlayerWeight = weight;
        PlayerHipCirc = hipCirc;
        PlayerWaistCirc = waistCirc;
        PlayerPrefs.SetString("PlayerName", name );
        PlayerPrefs.SetInt("PlayerAge", age);
        PlayerPrefs.SetFloat("PlayerHeight", height);
        PlayerPrefs.SetFloat("PlayerWeight", weight);
        PlayerPrefs.SetFloat("PlayerHipCirc", hipCirc);
        PlayerPrefs.SetFloat("PlayerWaistCirc", waistCirc);
        
        
        
        
    }
}
