using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatUI : BaseUI
{
    public TextMeshProUGUI atkTxt;
    public TextMeshProUGUI defTxt;
    public TextMeshProUGUI hpTxt;
    public TextMeshProUGUI critTxt;

    public Button backBtn;

    private void Awake()
    {
        backBtn = GetComponentInChildren<Button>();
        backBtn.onClick.AddListener(Back);
    }
    public override void SetActive()
    {
        atkTxt.text = CharacterManager.Instance._player.condition.atk.value.ToString();
        defTxt.text = CharacterManager.Instance._player.condition.def.value.ToString();
        hpTxt.text = CharacterManager.Instance._player.condition.hp.value.ToString();
        critTxt.text = CharacterManager.Instance._player.condition.crit.value.ToString();
        base.SetActive();
    }

    public void Back()
    {
        UIManager.Instance.mainscene.ChangeUITo(UIManager.Instance.mainscene.main);
    }
}
