using System;
using System.Linq;
using System.Collections.Generic;
using Assets._ScriptableObjects;
using UnityEngine;
using Assets._Scripts;
using Assets._Scripts.Utilities;
using Assets._Scripts.Characters;
using Assets._Scripts.Tiles;

namespace Assets._Scripts.Tiles
{
    public class TileAddToList : MonoBehaviour
    {
        [SerializeField]
        private so_TileContainer _tileContainer;

        [SerializeField]
        private TileData _tileData;

        void Awake()
        {
            _tileData.key = _tileContainer.tileList.Count + 1;
            _tileData.tileOverhead = gameObject;

            _tileContainer.tileList.Add(_tileData);
        }
    }
}
