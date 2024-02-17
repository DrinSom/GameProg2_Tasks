using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WeekDaysActivity : MonoBehaviour
{
    public DispWeekday dispWeekday;

    void Start()
    {
    
        switch(dispWeekday)
        {
        case DispWeekday.Monday: Debug.Log ("Monday"); break; 
        case DispWeekday.Tuesday: Debug.Log ("Tuesday"); break; 
        case DispWeekday.Wednesday: Debug.Log ("Wednesday"); break; 
        case DispWeekday.Thursday: Debug.Log ("Thursday"); break; 
        case DispWeekday.Friday: Debug.Log ("Friday"); break; 
        case DispWeekday.Saturday: Debug.Log ("Saturday"); break; 
        case DispWeekday.Sunday: Debug.Log ("Sunday"); break;
        
        }
    }

}
