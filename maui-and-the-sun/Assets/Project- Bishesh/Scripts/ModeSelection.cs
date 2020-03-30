using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ModeSelection : MonoBehaviour
{

    public Toggle easy;
    public Toggle intermediate;
    public Toggle hard;
    


    public void logToggle()
    {
        activeToggle();
    }
    public void activeToggle()
    {
        if (easy.isOn)
        {
            Debug.Log("easy");
        }
        else if (intermediate.isOn)
        {
            Debug.Log("intermediate");
        }
        else if (hard.isOn)
        {
            Debug.Log("hard");
        }
    }
   
   
}
