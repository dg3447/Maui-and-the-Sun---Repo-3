using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;
using UnityEngine.UI;

public class DoDamageOnTrigger : MonoBehaviour
{
    public PlayerMovement Damage;
    public TimerUI gameOver;
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ch-Maui")
        {
            Damage.takedamage(1);
            if (Damage.currentHealth <= 0)
            {
                Debug.Log("player died");
            }
            else
            {

            }
            
        }
    }
}
