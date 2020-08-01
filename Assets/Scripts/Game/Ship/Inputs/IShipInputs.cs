using System;
using UnityEngine;

namespace SpaceShooter.Game.Ship.Inputs
{
    public interface IShipInputs
    {
        Action OnShoot { get; set; }
        Action<Vector3> OnMove { get; set; }
    }
}