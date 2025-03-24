using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int inventorySize;
    public int curItemCount;
    public ItemSlot[] slots;
    public Item equippedWeapon;
    public Item equippedArmor;
    public Item equippedTrinket;



    private void Start()
    {
        Init();
    }

    public void Init()//제이슨을 이용해서 아이템을 불러온다면 여기서 불러올 것
    {
        equippedWeapon = null;
        equippedArmor = null;
        equippedTrinket = null;
        inventorySize = 20;
        slots = new ItemSlot[inventorySize];
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = new ItemSlot();
            slots[i].index = i;
        }
        for(int i = 0; i<ItemManager.Instance.items.Count; i++) // 테스트 용으로 모든 아이템 다 넣기
        {
            AddItem(ItemManager.Instance.items[i]);
        }

    }
    public void AddItem(Item data)
    {
        if (!CheckSameItem(data))
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].item == null)
                {
                    slots[i].item = data;
                    CountItem();
                    return;
                }
            }
        }

        Debug.Log("빈 슬롯이 없습니다.");
    }

    public void CountItem()
    {
        curItemCount = 0;
        foreach(ItemSlot slot in slots)
        {
            if(slot.item != null)
            {
                curItemCount++;
            }
        }
    }

    public bool CheckSameItem(Item data)
    {
        foreach (ItemSlot slot in slots)
        {
            if(slot.item == data)
            {
                Debug.Log("이미 가지고 있는 아이템입니다.");
                return true;
            }
        }
        return false;
    }

}


[Serializable]
public class ItemSlot
{
    public Item item;
    public int index;
}