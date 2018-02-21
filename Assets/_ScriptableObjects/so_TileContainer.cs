using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Assets._Scripts;
using Assets._Scripts.Utilities;
using Assets._Scripts.Characters;
using Assets._Scripts.Tiles;

namespace Assets._ScriptableObjects
{
    [CreateAssetMenu(fileName = "so_TileData", menuName = "so_TileData", order = 0)]
    public class so_TileContainer : ScriptableObject
    {
        /// <summary>
        /// List of the all the tiles that are active in the scene
        /// </summary>
        public List<TileData> tileList = new List<TileData>();

        public void Reset()
        {
            tileList = null;
            tileList = new List<TileData>();
        }
    }
}
