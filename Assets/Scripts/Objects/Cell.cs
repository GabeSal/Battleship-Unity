using System;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]
    private bool _containsShip = false;
    private bool _activeCell = true;

    public event Action<Cell> OnCellSelect;

    private void OnMouseDown()
    {
        if(_activeCell)
        {
            DisableCell();
            OnCellSelect?.Invoke(this);
            //Debug.Log(string.Format("{0} was selected.", this.gameObject.name));
        }
    }
    public void EnableCell()
    {
        _activeCell = true;
    }
    private void DisableCell()
    {
        _activeCell = false;
    }
}
