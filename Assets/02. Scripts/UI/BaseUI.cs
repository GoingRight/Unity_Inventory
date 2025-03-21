using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseUI : MonoBehaviour
{
    public virtual void SetActive()
    {
        this.gameObject.SetActive(true);
    }
}
