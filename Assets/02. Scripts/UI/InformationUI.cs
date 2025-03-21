using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InformationUI : MonoBehaviour
{
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI lvTxt;
    public TextMeshProUGUI expTxt;
    public Image expBar;
    public TextMeshProUGUI description;

    public void Start()
    {
        SetInformUI();
    }

    public void SetInformUI()
    {
        Debug.Log(CharacterManager.Instance._player.information.playerName);
        nameTxt.text = CharacterManager.Instance._player.information.playerName;
        lvTxt.text = CharacterManager.Instance._player.information.lv.ToString();
        expTxt.text = $"{CharacterManager.Instance._player.information.curExp}/{CharacterManager.Instance._player.information.maxExp}";
        expBar.fillAmount = (float)CharacterManager.Instance._player.information.curExp / CharacterManager.Instance._player.information.maxExp;
        description.text = CharacterManager.Instance._player.information.description;
    }
}
