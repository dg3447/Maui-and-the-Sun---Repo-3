using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;


public class meat : MonoBehaviour, IDropHandler
{
    private CanvasGroup CanvasGroup;
    public event EventHandler<OnItemDroppedEventArgs> OnItemDropped;
    public class OnItemDroppedEventArgs : EventArgs
    {
        public items items;
    }

    public void OnDrop(PointerEventData eventData)
    {
        items items = UI_ItemDrag.Instance.GetItem();
        OnItemDropped?.Invoke(this, new OnItemDroppedEventArgs { items = items });
        if (items.itemType == items.ItemType.meat)
        {
            Debug.Log("chicken dropped");
            if (eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                CanvasGroup = GetComponent<CanvasGroup>();
                CanvasGroup.alpha = 0;
            }
        }

    }
}
