using System;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField]
    private int _totalHits;
    private int _hitsRemaining;
    private MeshRenderer _shipGraphics;

    private void Awake()
    {
        _shipGraphics = GetComponent<MeshRenderer>();
        _shipGraphics.enabled = false;
    }

    public void SinkShip(Ship ship)
    {
        _shipGraphics.enabled = true;
    }
}
