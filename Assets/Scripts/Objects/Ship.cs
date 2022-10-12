using System;
using UnityEngine;

public class Ship : MonoBehaviour, ITakeHit
{
    [SerializeField]
    private int _totalHits;
    private int _hitsRemaining;
    private MeshRenderer _shipGraphics;

    private void Awake()
    {
        _shipGraphics = GetComponent<MeshRenderer>();
    }

    public void TakeDamage()
    {
        if (_hitsRemaining > 0)
        {
            _hitsRemaining--;
        }
        else
        {
            SinkShip(this);
        }
    }

    public int GetHitsRemaining()
    {
        return _hitsRemaining;
    }

    public int GetTotalHits()
    {
        return _totalHits;
    }

    public void SinkShip(Ship ship)
    {
        _shipGraphics.enabled = false;
    }
}
