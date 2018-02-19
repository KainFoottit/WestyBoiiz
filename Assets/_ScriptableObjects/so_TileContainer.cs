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
    [CreateAssetMenu(fileName = "so_TileContainer", menuName = "so_TileContainer", order = 0)]
    [Serializable]
    public class so_TileContainer : ScriptableObject
    {
        private int xLength = -1;
        private int zLength = -1;

        private TileData[,] _tileArray;
        /// <summary>
        /// List of the all the tiles that are active in the scene
        /// </summary>
        public TileData[,] tileArray
        {
            get
            {
                if (_tileArray == null)
                    ResetArray();
                return _tileArray;
            }
            set
            {
                _tileArray = value;
            }
        }

        public void Setup()
        {
            if (xLength < 0)
                xLength = GameObject.Find("APP_MANAGER").GetComponent<AppManager>().xLength;
            if (zLength < 0)
                zLength = GameObject.Find("APP_MANAGER").GetComponent<AppManager>().zLength;
        }

        public void ResetArray()
        {
            if (xLength < 0)
                xLength = GameObject.Find("APP_MANAGER").GetComponent<AppManager>().xLength;
            if (zLength < 0)
                zLength = GameObject.Find("APP_MANAGER").GetComponent<AppManager>().zLength;

            _tileArray = null;
            _tileArray = new TileData[xLength, zLength];

            for (int x = 0; x < xLength; x++)
            {
                for (int z = 0; z < zLength; z++)
                {
                    _tileArray = null;
                }
            }
        }
    }
}
