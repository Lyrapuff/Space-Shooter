using System;
using UnityEngine;

namespace SpaceShooter.Game.Ship.Inputs
{
    public interface IShipInputs
    {
        Action OnShoot { get; set; }
        Vector2 Direction { get; }
    }
}