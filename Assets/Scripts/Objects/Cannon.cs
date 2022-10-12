using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField]
    protected Transform _projectilePoint;
    [SerializeField]
    protected GameObject _projectile;

    public bool FoundProjectilePoint()
    {
        return _projectilePoint != null;
    }
}
