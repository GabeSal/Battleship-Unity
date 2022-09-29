using System;
using UnityEngine;

public abstract class Ship : MonoBehaviour, ITakeHit
{
    protected int _totalHits;
    protected int _hitsRemaining;

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
        ship.enabled = false;
    }
}
