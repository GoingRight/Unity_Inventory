using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public Stat atk;
    public Stat def;
    public Stat hp;
    public Stat crit;

    public void Add(Stat stat, int value)
    {
        stat.Add(value);
    }

    public void Subtract(Stat stat, int value)
    {
        stat.Subtract(value);
    }
}
