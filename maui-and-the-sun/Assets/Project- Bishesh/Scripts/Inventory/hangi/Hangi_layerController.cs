using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hangi_layerController : MonoBehaviour
{
    private Hangi_LayerSlot soil;
    private Hangi_LayerSlot leaves;
    private Hangi_LayerSlot meat;
    private Hangi_LayerSlot vege1;
    private Hangi_LayerSlot vege2;
    private Hangi_LayerSlot branches;
    private Hangi_LayerSlot smallStones;
    private Hangi_LayerSlot largeStones;
    [SerializeField]
    private Transform pfUI_Item;
    private Transform itemContainer;


    private void Awake()
    {
        itemContainer = transform.Find("itemContainer");
        soil = transform.Find("soil").GetComponent<Hangi_LayerSlot>();
        leaves = transform.Find("leaves").GetComponent<Hangi_LayerSlot>();
        meat = transform.Find("meat").GetComponent<Hangi_LayerSlot>();
        vege1 = transform.Find("vege1").GetComponent<Hangi_LayerSlot>();
        vege2 = transform.Find("vege2").GetComponent<Hangi_LayerSlot>();
        branches = transform.Find("branches").GetComponent<Hangi_LayerSlot>();
        smallStones = transform.Find("smallStones").GetComponent<Hangi_LayerSlot>();
        largeStones = transform.Find("largeStones").GetComponent<Hangi_LayerSlot>();

        soil.OnItemDropped += Soil_OnItemDropped;
        leaves.OnItemDropped += Leaves_OnItemDropped;
        meat.OnItemDropped += Meat_OnItemDropped;
        vege1.OnItemDropped += Vege1_OnItemDropped;
        vege2.OnItemDropped += Vege2_OnItemDropped;
        branches.OnItemDropped += Branches_OnItemDropped;
        smallStones.OnItemDropped += SmallStones_OnItemDropped;
        largeStones.OnItemDropped += LargeStones_OnItemDropped;
    }

    private void LargeStones_OnItemDropped(object sender, Hangi_LayerSlot.OnItemDroppedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void SmallStones_OnItemDropped(object sender, Hangi_LayerSlot.OnItemDroppedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Branches_OnItemDropped(object sender, Hangi_LayerSlot.OnItemDroppedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Vege2_OnItemDropped(object sender, Hangi_LayerSlot.OnItemDroppedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Vege1_OnItemDropped(object sender, Hangi_LayerSlot.OnItemDroppedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Meat_OnItemDropped(object sender, Hangi_LayerSlot.OnItemDroppedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Leaves_OnItemDropped(object sender, Hangi_LayerSlot.OnItemDroppedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Soil_OnItemDropped(object sender, Hangi_LayerSlot.OnItemDroppedEventArgs e)
    {
        Debug.Log("item dropped is:" + e.items);
    }
}
