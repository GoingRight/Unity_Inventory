using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Trinket
}

[CreateAssetMenu(fileName = "Item", menuName = "New ItemData")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string itemName;
    public ItemType itemType;
    public int idx;
    public float value;
    
    public void Equip()
    {
        if(itemType == ItemType.Weapon)
        {

        }
        else if(itemType == ItemType.Armor)
        {

        }
        else
        {

        }
    }
    public void UnEquip()
    {
        if (itemType == ItemType.Weapon)
        {

        }
        else if (itemType == ItemType.Armor)
        {

        }
        else
        {

        }
    }
}
