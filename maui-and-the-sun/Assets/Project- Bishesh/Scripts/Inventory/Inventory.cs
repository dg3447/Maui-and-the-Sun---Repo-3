using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<items> itemList;

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

        //addItem(new items { itemType = items.ItemType.hoe, amount = 1 });
        //addItem(new items { itemType = items.ItemType.paddle, amount = 1 });
        //addItem(new items { itemType = items.ItemType.patu, amount = 1 });
        //addItem(new items { itemType = items.ItemType.banana, amount = 1 });
        //addItem(new items { itemType = items.ItemType.chicken, amount = 1 });
        //addItem(new items { itemType = items.ItemType.pumpkin, amount = 1 });
        //addItem(new items { itemType = items.ItemType.carrot, amount = 1 });

        //addItem(new items { itemType = items.ItemType.hoe, amount = 1 });
        //addItem(new items { itemType = items.ItemType.paddle, amount = 1 });
        //addItem(new items { itemType = items.ItemType.patu, amount = 1 });
        //addItem(new items { itemType = items.ItemType.banana, amount = 1 });
        //addItem(new items { itemType = items.ItemType.chicken, amount = 1 });
        //addItem(new items { itemType = items.ItemType.pumpkin, amount = 1 });
        //addItem(new items { itemType = items.ItemType.carrot, amount = 1 });


    }

    public void addItem(items item)
    {
        itemList.Add(item);
    }

    public List<items> GetItemList()
    {
        return itemList;
    }





}
  

