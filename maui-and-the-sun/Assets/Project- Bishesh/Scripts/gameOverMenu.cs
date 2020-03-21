using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameOverMenu : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("application quite!");
        Application.Quit();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
