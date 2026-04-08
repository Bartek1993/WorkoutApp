using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UIElements.Button;

public class ExercisePanel : MonoBehaviour
{
    public MasterScript masterScript;
    public GameObject exercisePrefab, objectExercise;
    public Transform exercisePanel;
    [SerializeField]
    public string currentExercise, notes;
    public float weight, km, metr, centm, h, min, seco, ms;
    public int reps;
    public int setNumber;
    public InputField [] userInputFields;
    public string uniqueID;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        masterScript = GameObject.Find("SCRIPTMAIN").GetComponent<MasterScript>();
        setNumber = 0;
        for (var i = 0; i < setNumber; i++)
        {
            Instantiate(objectExercise, exercisePanel);
            objectExercise.GetComponent<ExerciseButton>().SetExercise(setNumber, currentExercise, weight, reps, notes,km,
                metr, h, min, seco, ms);
        }

    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void onSubmit()
    {
        
        currentExercise = userInputFields[0].text;
        weight = float.Parse(userInputFields[1].text);
        reps = int.Parse(userInputFields[2].text);
        km = float.Parse(userInputFields[3].text);
        metr = float.Parse(userInputFields[4].text);
        h = float.Parse(userInputFields[5].text);
        min = float.Parse(userInputFields[6].text);
        seco = float.Parse(userInputFields[7].text);
        ms = float.Parse(userInputFields[8].text);
        notes = userInputFields[9].text;
        AddToPanel();
      
        
    }
    
    


    public void AddToPanel()
    {

        objectExercise = exercisePrefab;
        if (currentExercise.Length == 0)
        {
            masterScript.promptWindow.promptWindowMain.SetActive(true);
            masterScript.promptWindow.DisplayPrompt(3,1,true,false,0,45);
        }
        else
        {
            setNumber += 1;
            Instantiate(objectExercise, exercisePanel);
            objectExercise.GetComponent<ExerciseButton>().SetExercise(setNumber, currentExercise, weight, reps, notes,km,
                metr, h, min, seco, ms);
            
        }
        
        
        
        

    }
    
    




}
