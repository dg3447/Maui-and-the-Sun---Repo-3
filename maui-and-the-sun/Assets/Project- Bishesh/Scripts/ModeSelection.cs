using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ModeSelection : MonoBehaviour
{

    ToggleGroup toggleGroupInstance;
    TimerUI timerInstance;

    public Toggle currentSelection
    {
        get { return toggleGroupInstance.ActiveToggles().FirstOrDefault(); }
    }
    void Start()
    {
        toggleGroupInstance = GetComponent<ToggleGroup>();
        // Debug.Log("First Selected" + currentSelection.name);
       
    }
    
   

    public void selectToggle(int id)
    {
        var toggles = toggleGroupInstance.GetComponentsInChildren <Toggle>();   //creating array of mode selection
       
       
        if (toggles[0])
        {
           
            Debug.Log(currentSelection.name);
            
        }
        else if (toggles[1])
        {
          
            Debug.Log(currentSelection.name);
           
        }
        else if (toggles[2])
        {
           
            Debug.Log(currentSelection.name);
           
        }
        else
        {
            toggles[0].isOn = true;
        }
        toggles[id].isOn = true;
    }


   
    //public void easy()
    //{
    //    selectToggle(0);
    //    Debug.Log(currentSelection.name);
    //}

    //public void intermediate()
    //{
    //    selectToggle(1);
    //    Debug.Log(currentSelection.name);
    //}
  
    //public void hard()
    //{
    //    selectToggle(2);
    //    Debug.Log(currentSelection.name);
    //}
    
   
}
