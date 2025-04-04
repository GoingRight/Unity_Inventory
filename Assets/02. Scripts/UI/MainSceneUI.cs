using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneUI : MonoBehaviour
{
    public MainUI main;
    public StatUI status;
    public InventoryUI inventory;
    public InformationUI information;

    public List<GameObject> changingUI = new List<GameObject>();

    private void Awake()
    {
        main = GetComponentInChildren<MainUI>(true);
        status = GetComponentInChildren<StatUI>(true);
        inventory = GetComponentInChildren<InventoryUI>(true);
        information = GetComponentInChildren<InformationUI>();

        changingUI.Add(main.gameObject);
        changingUI.Add(status.gameObject);
        changingUI.Add(inventory.gameObject);
    }

    private void Start()
    {
        UIManager.Instance.mainscene = this;
        ChangeUITo(main);
    }

    public void ChangeUITo(BaseUI ui)
    {
        foreach(GameObject go in changingUI)
        {
            go.SetActive(false);
        }
        ui.gameObject.SetActive(true);
    }
}
