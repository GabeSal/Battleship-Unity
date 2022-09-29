using System;
using UnityEngine;

public abstract class Cell : MonoBehaviour
{
    protected bool _containsShip;

    public event Action<Cell> OnCellSelect;

    public void EnableCell()
    {
        gameObject.SetActive(true);
    }

    public void DisableCell()
    {
        gameObject.SetActive(false);
    }

    public bool CheckForShip()
    {
        return _containsShip;
    }
}
