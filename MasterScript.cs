using System;
using UnityEngine;

public class MasterScript : MonoBehaviour
{
    public static MasterScript instance {get; private set; }
    public PlayerData playerData;
    public SetUserData setUserData;
    public PromptWindow promptWindow;
    public AudioManager audioManager;
    public UserStatsPanel userStatsPanel;
    public UpdateMeasurements updateMeasurements;
    public int userDetailsComplete, userMenuTutorialComplete;
    public GameObject userDetailInputPanel, userMainPanel;


    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }


    void Start()
    {
        if (!PlayerPrefs.HasKey("userDetailsComplete"))
        {
            userDetailsComplete = 0;
            PlayerPrefs.SetInt("userDetailsComplete", userDetailsComplete);
        }
        else
        {
            userDetailsComplete = PlayerPrefs.GetInt("userDetailsComplete");
       
        }

        StartCheck();
    }

    public void StartCheck()
    {
        if (PlayerPrefs.GetInt("userDetailsComplete") == 1)
        {
            userDetailInputPanel.SetActive(false);
            userMainPanel.SetActive(true);
        }
        else
        {
            userDetailInputPanel.SetActive(true);
            userMainPanel.SetActive(false);
        }
    }
}
