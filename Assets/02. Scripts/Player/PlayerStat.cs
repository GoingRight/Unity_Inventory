using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public Stat atk = new Stat();
    public Stat def = new Stat();
    public Stat hp = new Stat();
    public Stat crit = new Stat();

    private void Awake()
    {
        Init();
    }

    public void Add(Stat stat, int value)
    {
        stat.Add(value);
    }

    public void Subtract(Stat stat, int value)
    {
        stat.Subtract(value);
    }

    public void Init()
    {
        atk.value = 35;
        def.value = 40;
        hp.value = 100;
        crit.value = 25;
    }
}
