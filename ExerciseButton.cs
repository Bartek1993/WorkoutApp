using UnityEngine;
using UnityEngine.UI;

public class ExerciseButton : MonoBehaviour
{
    public ExercisePanel exercisePanel;
    public string currentExercise, notes;
    public string uniqueID;
    public float weight;
    public int reps;
    public float km, metr, centm, h, min, seco, ms;
    public int setNumber;
    public float deleteTimer;
    public bool isTimer;
    public Text nameText;
    void Start()
    {
        exercisePanel = GetComponentInParent<ExercisePanel>();
        nameText = GetComponentInChildren<Text>();
        deleteTimer = 0;
        nameText.text = setNumber + ": " + currentExercise;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isTimer)
        {
            deleteTimer += 2 * Time.deltaTime;
        }
        else
        {
            deleteTimer = 0;
        }
        if (deleteTimer >= 2)
        {
            Destroy(gameObject);
        }
    }


    public void SetExercise(int setNo, string exerciseName, float exerciseWeight, int exerciseReps, string exerciseNotes,
        float kilm, float met, float hour, float minu, float sec, float milsec)
    {
        currentExercise = exerciseName;
        notes = exerciseNotes;
        weight = exerciseWeight;
        reps = exerciseReps;
        km = kilm;
        metr = met;
        h =  hour;
        min = minu;
        seco = sec;
        ms = milsec;
        setNumber = setNo;
        uniqueID = exerciseName+setNo;
        
    }

    public void IncreaseTimer()
    {
        isTimer = true;
    }

    public void DecreaseTimer()
    {
        isTimer = false;
    }







}
