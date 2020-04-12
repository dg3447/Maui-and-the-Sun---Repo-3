using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigerInventory : MonoBehaviour
{
    public GameObject hangi;
    
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ch-Maui")
        {
            hangi.transform.gameObject.SetActive(true);
        } 
    }
   

}
