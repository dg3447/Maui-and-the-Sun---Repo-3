using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthEffect : MonoBehaviour
{
    public GameObject effect;
    private Transform player;
    private PlayerMovement PlayerHealth;
   
   
    private void Start()
    {
        player = GameObject.Find("Ch-Maui").GetComponent<Transform>();
        PlayerHealth = GameObject.Find("Ch-Maui").GetComponent<PlayerMovement>();
    }

    public void useItem()
    {
        Instantiate(effect, player.position, Quaternion.identity);
        Destroy(gameObject);
        PlayerHealth.increaseHealth(1);
    }
}
