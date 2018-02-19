using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Assets._Scripts;
using Assets._Scripts.Utilities;
using Assets._Scripts.Characters;

namespace Assets._Scripts.Characters
{
    public interface ICharacter
    {
        /// <summary>
        /// Health of the character
        /// </summary>
        int health { get; set; }

        /// <summary>
        /// Current stamina of the character
        /// </summary>
        int stamina { get; set; }
        /// <summary>
        /// Rate at which stamina regenerates
        /// </summary>
        int staminaRegen { get; set; }
        /// <summary>
        /// Number of actions that the character can take per turn
        /// </summary>
        int actionPoints { get; set; }

        /// <summary>
        /// Melee damage modifier, +1 damage / 3 strength 
        /// </summary>
        int strength { get; set; }

        /// <summary>
        /// Ranged hit chance, % out of 100
        /// </summary>
        int accuracy { get; set; }
    }
}
