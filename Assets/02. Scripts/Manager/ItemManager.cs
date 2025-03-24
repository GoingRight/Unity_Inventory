using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : Singleton<ItemManager>
{
    public List<ItemData> itemDatas = new List<ItemData>();
    public List<Item> items = new List<Item>();
    private void Start()
    {
        for(int i = 0; i < itemDatas.Count; i++)
        {
            Item item = new Item();
            item.data = itemDatas[i];
            items.Add(item);
        }
    }
}
