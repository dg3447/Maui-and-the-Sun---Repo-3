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

        soil,
        leaves,
        vege1,
        meat,
        vege2,
        branches,
        smallStones,
        largeStones,
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

            case ItemType.soil: return ItemAssets.Instance.soilSprite;
            case ItemType.leaves: return ItemAssets.Instance.leavesSprite;
            case ItemType.vege1: return ItemAssets.Instance.vege1Sprite;
            case ItemType.meat: return ItemAssets.Instance.meatSprite;
            case ItemType.vege2: return ItemAssets.Instance.vege2Sprite;
            case ItemType.branches: return ItemAssets.Instance.branchesSprite;
            case ItemType.smallStones: return ItemAssets.Instance.smallStonesSprite;
            case ItemType.largeStones: return ItemAssets.Instance.largeStonesSprite;
        }
    }


    public bool IsStackable()
    {
        switch (itemType)
        {
            default:
            case ItemType.soil:
            case ItemType.leaves:
            case ItemType.meat:
            case ItemType.vege1:
            case ItemType.vege2:
            case ItemType.branches:
            case ItemType.smallStones:
            case ItemType.largeStones:
                return true;

           
            case ItemType.hoe:
            case ItemType.paddle:
            case ItemType.patu:
                return false;

        }
    }

}
