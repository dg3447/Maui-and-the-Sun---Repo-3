using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playerDeath : MonoBehaviour
{
    private PlayerMovement player;
    private gameOverMenu gameOver;
    private TimerUI timer;
   

    private void Start()
    {
        player = GameObject.Find("Ch-Maui").GetComponent<PlayerMovement>();
        gameOver = GameObject.Find("gameOverScreen").GetComponent<gameOverMenu>();
        timer = GameObject.Find("Timer").GetComponent<TimerUI>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ch-Maui")
        {
            player.myAnimator.SetLayerWeight(2, 1);
            player.myAnimator.SetTrigger("dead");
            StartCoroutine("wait");
            Destroy(timer);
            gameOver.gameObject.SetActive(true);
        }
    }
   public IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        Destroy(GameObject.Find("Ch-Maui"));
    }


}
