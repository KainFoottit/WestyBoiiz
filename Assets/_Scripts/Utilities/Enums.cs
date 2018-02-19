using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Assets._Scripts;
using Assets._Scripts.Utilities;
using Assets._Scripts.Characters;

namespace Assets._Scripts.Utilities
{
    public static class Enums
    {
        /// <summary>
        /// Empty - Tile is empty,
        /// PlayerFilled - A player character is standing on the tile,
        /// EnemyFilled - An enemy character is standing on the tile
        /// </summary>
        public enum OccupiedState
        {
            empty = 0,
            playerFilled,
            enemyFilled
        }

        /// <summary>
        /// Empty - Can be passed through with no penalty,
        /// Door - Can be passed through with door penalty,
        /// Impassable - Cannot be passed through
        /// </summary>
        public enum TilePassability
        {
            empty = 0,
            door,
            stairs,
            water,
            impassable
        }
    }
}
