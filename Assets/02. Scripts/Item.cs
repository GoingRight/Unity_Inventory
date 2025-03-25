using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public ItemData data;
    private bool isEquipped = false;
    public bool IsEquipped
    {
        get { return isEquipped; }
        set
        {
            isEquipped = value;
            onChangeEquip?.Invoke(value);
        }
    }


    public Action<bool> onChangeEquip;
    public void Equip()
    {
        if (data.itemType == ItemType.Weapon)
        {
            if (CharacterManager.Instance._player.inventory.equippedWeapon != null)
            {
                CharacterManager.Instance._player.inventory.equippedWeapon.UnEquip();
            }
            CharacterManager.Instance._player.inventory.equippedWeapon = this;
            CharacterManager.Instance._player.condition.atk.value += data.value;
        }
        else if (data.itemType == ItemType.Armor)
        {
            if (CharacterManager.Instance._player.inventory.equippedArmor != null)
            {
                CharacterManager.Instance._player.inventory.equippedArmor.UnEquip();
            }
            CharacterManager.Instance._player.inventory.equippedArmor = this;
            CharacterManager.Instance._player.condition.def.value += data.value;
        }
        else
        {
            if (CharacterManager.Instance._player.inventory.equippedTrinket != null)
            {
                CharacterManager.Instance._player.inventory.equippedTrinket.UnEquip();
            }
            CharacterManager.Instance._player.inventory.equippedTrinket = this;
            switch (data.trinketBuffIdx)
            {
                case 0:
                    CharacterManager.Instance._player.condition.atk.value += data.value;
                    break;
                case 1:
                    CharacterManager.Instance._player.condition.def.value += data.value;
                    break;
                case 2:
                    CharacterManager.Instance._player.condition.hp.value += data.value;
                    break;
                case 3:
                    CharacterManager.Instance._player.condition.crit.value += data.value;
                    break;
                default:
                    Debug.LogWarning("뭔가 잘못됨");
                    break;
            }
        }
        IsEquipped = true;
    }
    public void UnEquip()
    {
        if (data.itemType == ItemType.Weapon)
        {
            CharacterManager.Instance._player.inventory.equippedWeapon = null;
            CharacterManager.Instance._player.condition.atk.value -= data.value;
        }
        else if (data.itemType == ItemType.Armor)
        {
            CharacterManager.Instance._player.inventory.equippedArmor = null;
            CharacterManager.Instance._player.condition.def.value -= data.value;
        }
        else
        {
            CharacterManager.Instance._player.inventory.equippedTrinket = null;
            switch (data.trinketBuffIdx)
            {
                case 0:
                    CharacterManager.Instance._player.condition.atk.value -= data.value;
                    break;
                case 1:
                    CharacterManager.Instance._player.condition.def.value -= data.value;
                    break;
                case 2:
                    CharacterManager.Instance._player.condition.hp.value -= data.value;
                    break;
                case 3:
                    CharacterManager.Instance._player.condition.crit.value -= data.value;
                    break;
                default:
                    Debug.LogWarning("뭔가 잘못됨");
                    break;
            }
        }
        IsEquipped = false;
    }
}
