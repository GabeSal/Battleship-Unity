using System;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]
    private bool _containsShip = false;

    public event Action<Cell> OnCellSelect;

    private void OnTriggerEnter(Collider ship)
    {
        if (ship.CompareTag("Ship"))
        {
            //Debug.Log(string.Format("A ship was found at {0}!", this.name));
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
