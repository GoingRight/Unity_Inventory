using System.Collections;
using System.Collections.Generic;

public class Stat
{
    public string Name { get; set; }
    public int value;

    public void Add(int value)
    {
        this.value += value;
    }

    public void Subtract(int value)
    {
        this.value -= value;
    }
}
