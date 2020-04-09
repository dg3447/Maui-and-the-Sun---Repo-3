using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class items 
{
    public enum ItemType
    {
        hoe,
        paddle,
        patu,
        banana,
        chicken,
        pumpkin,
        carrot,

    }

    public ItemType itemType;
    public int amount;


    public Sprite GetSprite()
    {
        return GetSprite(itemType);
    }
    public Sprite GetSprite(ItemType itemType)
    {
        switch (itemType)
        {
            default:
            case ItemType.hoe:     return ItemAssets.Instance.hoeSprite;
            case ItemType.paddle:  return ItemAssets.Instance.paddleSprite;
            case ItemType.patu:    return ItemAssets.Instance.patuSprite;
            case ItemType.banana: return ItemAssets.Instance.bananaSprite;
            case ItemType.chicken: return ItemAssets.Instance.chickenSprite;
            case ItemType.pumpkin: return ItemAssets.Instance.pumpkinSprite;

        }
    }


    public bool IsStackable()
    {
        switch (itemType)
        {
            default:
            case ItemType.hoe:
            case ItemType.paddle:
            case ItemType.patu:
            return true;

            case ItemType.banana:
             return false;
        }
    }

}
