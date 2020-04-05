using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory
{
    private List<items> itemList;

    public event EventHandler  OnItemListChange;

    public Inventory()
    {
        itemList = new List<items>();
        

        addItem(new items { itemType = items.ItemType.hoe, amount = 1 });
        addItem(new items { itemType = items.ItemType.paddle, amount = 1 });
        addItem(new items { itemType = items.ItemType.patu, amount = 1 });
        addItem(new items { itemType = items.ItemType.banana, amount = 1 });
        addItem(new items { itemType = items.ItemType.chicken, amount = 1 });
        addItem(new items { itemType = items.ItemType.pumpkin, amount = 1 });
        addItem(new items { itemType = items.ItemType.carrot, amount = 1 });


    }

    public void addItem(items item)
    {
        if (item.IsStackable())
        {
            bool itemAlreadyInInventory = false;

            foreach (items inventoryItem in itemList)
            {
                if (inventoryItem.itemType == item.itemType)
                {
                    inventoryItem.amount += item.amount;
                    itemAlreadyInInventory = true;
                }
            }
            if (!itemAlreadyInInventory)
            {
                itemList.Add(item);
            }
        }
        else
        {
            itemList.Add(item);
        }
       
        OnItemListChange?.Invoke(this, EventArgs.Empty);

    }


    public List<items> GetItemList()
    {
        return itemList;
    }





}
  

