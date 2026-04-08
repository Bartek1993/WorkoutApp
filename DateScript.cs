using System;
using UI.Dates;
using UnityEngine;
using UnityEngine.UI;

public class DateScript : MonoBehaviour
{

    public string currentDate;
    public Text dateText;
    public bool displayDatePicker;
    public GameObject datePicker;
    public DatePicker callendarMain;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        displayDatePicker = false;
        string datee = DateTime.Now.ToString("yyyy/MM/dd");
        currentDate = datee;

    }

    // Update is called once per frame
    void Update()
    {
        datePicker.gameObject.SetActive(displayDatePicker);
        dateText.text = currentDate;
        currentDate = callendarMain.SelectedDate.ToDateString();
    }



    public void SetPickerVisibility()
    {
        displayDatePicker = !displayDatePicker;
    }
}
