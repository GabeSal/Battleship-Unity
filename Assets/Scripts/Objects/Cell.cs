using System;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]
    private bool _containsShip = false;
    private BoxCollider _cellCollider;

    public event Action<Cell> OnCellSelect;

    private void Awake()
    {
        _cellCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider ship)
    {
        if (ship != null && ship.CompareTag("Ship"))
        {
            _containsShip = true;
        }
    }

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
