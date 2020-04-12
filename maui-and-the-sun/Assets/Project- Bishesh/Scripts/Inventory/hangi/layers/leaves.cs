using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class leaves : MonoBehaviour, IDropHandler
{
    public event EventHandler<OnItemDroppedEventArgs> OnItemDropped;
    private Image checkedImage;
   
    public class OnItemDroppedEventArgs : EventArgs
    {
        public items items;
    }

   
    private void Start()
    {
        checkedImage = transform.Find("checked").GetComponent<Image>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        items items = UI_ItemDrag.Instance.GetItem();
        OnItemDropped?.Invoke(this, new OnItemDroppedEventArgs { items = items });

        if (items.itemType == items.ItemType.leaves)
        {
            UI_Item d = eventData.pointerDrag.GetComponent<UI_Item>();
            if (eventData.pointerDrag != null)
            {
                d.parentToReturn = this.transform;
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                UI_ItemDrag.Instance.Hide();
                checkedImage.gameObject.SetActive(true);
            }
        }
    }


}
