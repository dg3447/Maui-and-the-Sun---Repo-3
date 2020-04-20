using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpItem : MonoBehaviour
{
    private collectables collectables;
    public GameObject itemButton;

    private void Start()
    {
        collectables = GameObject.Find("Ch-Maui").GetComponent<collectables>();
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Ch-Maui")
        {
            for (int i = 0; i < collectables.slots.Length; i++)
            {
                if (collectables.isFull[i] == false)
                {
                    //add item
                    collectables.isFull[i] = true;
                    Instantiate(itemButton, collectables.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
