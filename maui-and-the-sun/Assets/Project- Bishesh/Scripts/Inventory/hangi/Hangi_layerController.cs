using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hangi_layerController : MonoBehaviour
{
    private soil soil;
    private leaves leaves;
    private meat meat;
    private vege1 vege1;
    private vege2 vege2;
    private branches branches;
    private smallStones smallStones;
    private largeStones largeStones;
    [SerializeField]
    private Transform pfUI_Item;
    private Transform itemContainer;

    int count;
    private void Awake()
    {
        itemContainer = transform.Find("itemContainer");
        soil = transform.Find("soil").GetComponent<soil>();
        leaves = transform.Find("leaves").GetComponent<leaves>();
        meat = transform.Find("meat").GetComponent<meat>();
        vege1 = transform.Find("vege1").GetComponent<vege1>();
        vege2 = transform.Find("vege2").GetComponent<vege2>();
        branches = transform.Find("branches").GetComponent<branches>();
        smallStones = transform.Find("smallStones").GetComponent<smallStones>();
        largeStones = transform.Find("largeStones").GetComponent<largeStones>();
    }

    
  
  
}
