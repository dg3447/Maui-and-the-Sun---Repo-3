using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hangi_layerController : MonoBehaviour
{
    public static int checkmarkCount = 0;
   
   
    private void Update()
    {
        LayersCompleted();
    }
    public void LayersCompleted()
    {
        if (checkmarkCount == 8)
        {
            gameObject.SetActive(false);
            
        }
        
    }
  
  
}
