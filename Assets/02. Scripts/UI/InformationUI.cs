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
    public TextMeshProUGUI goldTxt;
    public Image expBar;
    public TextMeshProUGUI description;

    public void Start()
    {
        SetInformUI();
    }

    public void SetInformUI()
    {
        nameTxt.text = CharacterManager.Instance._player.information.playerName;
        lvTxt.text = CharacterManager.Instance._player.information.lv.ToString();
        expTxt.text = $"{CharacterManager.Instance._player.information.curExp}/{CharacterManager.Instance._player.information.maxExp}";
        expBar.fillAmount = (float)CharacterManager.Instance._player.information.curExp / CharacterManager.Instance._player.information.maxExp;
        goldTxt.text = GoldTextSet(CharacterManager.Instance._player.information.gold);
        description.text = CharacterManager.Instance._player.information.description;
    }

    public string GoldTextSet(int gold)
    {
        List<string> quotients = new List<string>();
        while(gold > 1000)
        {
            int remainders = gold % 1000;
            quotients.Add(remainders.ToString("D3"));
            gold /= 1000;

        }
        quotients.Reverse();
        for(int i = 0; i < quotients.Count; i++)
        {
            quotients[i] = "," + quotients[i];
        }
        string str = gold.ToString();
        for(int i = 0; i < quotients.Count; i++)
        {
            str += quotients[i];
        }

        return str;
    }
}
