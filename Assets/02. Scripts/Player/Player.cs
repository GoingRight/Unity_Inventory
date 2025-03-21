using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerInformation information;
    public PlayerStat condition;
    public PlayerInventory inventory;
    private void Awake()
    {
        information = GetComponent<PlayerInformation>();
        condition = GetComponent<PlayerStat>();
        inventory = GetComponent<PlayerInventory>();
        CharacterManager.Instance._player = this;
    }
}
