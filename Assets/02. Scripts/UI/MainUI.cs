using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : BaseUI
{
    public Button statBtn;
    public Button inventoryBtn;

    private void Awake()
    {
        Button[] buttons = GetComponentsInChildren<Button>();

        foreach(Button btn in buttons)
        {
            if (btn.gameObject.name == "StatusBtn")
            {
                statBtn = btn;
            }
            else if(btn.gameObject.name == "InventoryBtn")
            {
                inventoryBtn = btn;
            }
        }
        statBtn.onClick.AddListener(ToStatUI);
        inventoryBtn.onClick.AddListener(ToInventoryUI);
    }

    public void ToStatUI()
    {
        UIManager.Instance.mainscene.ChangeUITo(UIManager.Instance.mainscene.status);
    }

    public void ToInventoryUI()
    {
        UIManager.Instance.mainscene.ChangeUITo(UIManager.Instance.mainscene.inventory);
    }
}
