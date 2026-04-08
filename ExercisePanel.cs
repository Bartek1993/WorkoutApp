using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ExercisePanel : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Dropdown dropdownBodyPart, dropdownExercises;
    public Transform exercisePanel;
    public string [] bodyParts,exerciseAbdominal,exerciseBiceps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetBodyPart();
        dropdownBodyPart.AddOptions(new List<string>(bodyParts));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBodyPart()
    {
        dropdownExercises.ClearOptions();
        if (dropdownBodyPart.value == 0)
        {
            dropdownExercises.AddOptions(new List<string>(exerciseAbdominal));
        }

        if (dropdownBodyPart.value == 1)
        {
            dropdownExercises.AddOptions(new List<string>(exerciseBiceps));
        }
        
       
    }

    
}
