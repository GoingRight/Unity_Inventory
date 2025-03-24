using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : BaseUI
{
    public PlayerInventory inventory;
    public TextMeshProUGUI curItemCountTxt;
    public TextMeshProUGUI maxItemCountTxt;
    public Transform slots;
    public UIItemSlot[] uiSlots;
    public GameObject slotUIPrefab;
    public Button backBtn;

    private void Awake()
    {
        backBtn.onClick.AddListener(Back);
    }

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        inventory = CharacterManager.Instance._player.inventory;
        curItemCountTxt.text = inventory.curItemCount.ToString();
        maxItemCountTxt.text = "/" + inventory.inventorySize.ToString();
        uiSlots = new UIItemSlot[inventory.inventorySize];
        for(int i = 0; i < uiSlots.Length; i++)
        {
            uiSlots[i] = Instantiate(slotUIPrefab, slots).GetComponent<UIItemSlot>();
            uiSlots[i].index = i;
        }
        SetUIItemSlot();
    }

    public void SetUIItemSlot()
    {
        for(int i = 0; i < uiSlots.Length; i++)
        {
            if (inventory.slots[i].item != null)
            {
                uiSlots[i].icon.sprite = inventory.slots[i].item.data.icon;
                inventory.slots[i].item.onChangeEquip = uiSlots[i].ToggleEquipMark;
            }
        }
    }

    public void Back()
    {
        UIManager.Instance.mainscene.ChangeUITo(UIManager.Instance.mainscene.main);
    }
}
