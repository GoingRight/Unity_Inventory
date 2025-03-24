using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
   

    public Sprite icon;

    public int value;
    public int trinketBuffIdx;
}
