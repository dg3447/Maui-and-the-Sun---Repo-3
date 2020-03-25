using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemScript : MonoBehaviour
{


    void OnTriggerEnter2D (Collider2D col)
    {

        GameControlScript.health -= 1;



    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
