using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonHandler : MonoBehaviour
{
    public GameObject hangiLayerController;
    public GameObject messageBoxHangi;
    public GameObject playerInstruct;
    public GameObject hangiInfo;
    public GameObject congratulationBox;
    public GameObject maui;



    public void ShowHangiLayer()
    {
        messageBoxHangi.gameObject.SetActive(false);
        playerInstruct.gameObject.SetActive(true);
        hangiLayerController.gameObject.SetActive(true);
        StartCoroutine(RemoveAfterSeconds(10, playerInstruct.gameObject));
    }
   
    public void showHangiInfo()
    {
        congratulationBox.gameObject.SetActive(false);
        hangiInfo.gameObject.SetActive(true);
        maui.gameObject.SetActive(false);
    }

    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(10);
        obj.SetActive(false);
    }

    public void openLink()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=7kwu6c7rN0I");
    }


}
