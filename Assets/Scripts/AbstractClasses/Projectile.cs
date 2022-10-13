using System;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    [SerializeField]
    protected float speed;
    [SerializeField]
    protected Vector3 direction;

    public event Action<Ship> OnImpact;
}
