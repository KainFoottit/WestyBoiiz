using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Assets._Scripts;
using Assets._Scripts.Utilities;
using Assets._Scripts.Characters;

namespace Assets._Scripts.Tiles
{
    /// <summary>
    /// Unity Transform component uses roughly 500Bytes of memory or 16 Cache calls
    /// Structs assign space linearly in memory so iterations are faster
    /// </summary>
    [Serializable]
    public struct TileData
    {
        /// <summary>
        /// Unique key that can be searched for
        /// </summary>
        public int key;                                 //4Byte
        /// <summary>
        /// Reference to empty overhead GameObject
        /// </summary>
        public GameObject tileOverhead;                 //8Byte

        /// <summary>
        /// X Position of the tile in World Space
        /// </summary>
        public int xPos;                                //4Byte
        /// <summary>
        /// Z Position of the tile in World Space
        /// </summary>
        public int zPos;                                //4Byte

        /// <summary>
        /// Stores whether the tile is currently empty or occupied
        /// </summary>
        public Enums.OccupiedState occupiedState;       //4Byte
        /// <summary>
        /// Stores whether the tile can be easily passed through 
        /// </summary>
        public Enums.TilePassability tilePassability;   //4Byte
    }
}
