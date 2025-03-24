using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItemSlot : MonoBehaviour
{
    public Button button;
    public Image icon;
    public Image equipMark;
    public int index;

    private void Awake()
    {
        button = GetComponentInChildren<Button>();
        equipMark.gameObject.SetActive(false);
        button.onClick.AddListener(ItemEquipManage);
    }


    public void ItemEquipManage()
    {
        if (CharacterManager.Instance._player.inventory.slots[index].item == null) return;

        if (CharacterManager.Instance._player.inventory.slots[index].item.IsEquipped == false)
        {
            CharacterManager.Instance._player.inventory.slots[index].item.Equip();
        }
        else
        {
            CharacterManager.Instance._player.inventory.slots[index].item.UnEquip();
        }

    }

    public void ToggleEquipMark(bool IsEquiped)
    {
        equipMark.gameObject.SetActive(IsEquiped);
    }
}
