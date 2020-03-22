using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;

public class DoDamageOnTrigger : MonoBehaviour
{
    public PlayerMovement Damage;
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ch-Maui")
        {
            Damage.takedamage(1);
            
        }
    }
}
