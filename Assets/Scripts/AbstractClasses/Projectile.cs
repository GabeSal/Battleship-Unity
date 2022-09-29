using System;
using UnityEngine;

public abstract class Projectile : MonoBehaviour, IDamageShip
{
    [SerializeField]
    protected float speed;
    [SerializeField]
    protected Vector3 direction;

    public event Action<Ship> OnImpact;

    public void DamageShip(Ship ship)
    {
        ship.TakeDamage();
    }
}
