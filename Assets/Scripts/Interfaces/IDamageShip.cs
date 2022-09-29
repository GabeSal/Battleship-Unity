using System;

public interface IDamageShip
{
    public event Action<Ship> OnImpact;

    public void DamageShip(Ship ship);
}
