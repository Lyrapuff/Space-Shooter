using System;
using SpaceShooter.Game.Ship.Inputs;
using UnityEngine;

namespace Game.Ship.Animations
{
    [RequireComponent(typeof(Animator))]
    public class ShipAnimator : MonoBehaviour
    {
        [SerializeField] private IShipInputs _shipInputs;
    }
}