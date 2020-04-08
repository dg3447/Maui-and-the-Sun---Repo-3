using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hangi_LayerSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
       items items = UI_ItemDrag.Instance.GetItem();
        Debug.Log(items);
    }
}
