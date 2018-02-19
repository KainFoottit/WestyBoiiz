using System;
using System.Linq;
using System.Collections.Generic;
using Assets._ScriptableObjects;
using UnityEngine;
using UnityEditor;
using Assets._Scripts;
using Assets._Scripts.Utilities;
using Assets._Scripts.Characters;
using Assets._Scripts.Tiles;

namespace Assets._Scripts.Tiles
{
    [ExecuteInEditMode]
    public class TileAddToList : MonoBehaviour
    {
        [SerializeField]
        private so_TileContainer _tileContainer;

        [SerializeField]
        private TileData _tileData;

        private void Awake()
        {
            _tileContainer = GameObject.Find("APP_MANAGER").GetComponent<AppDependencies>().tileContainer;
        }

        private void Start()
        {
            UpdateData();

            _tileContainer.tileArray[_tileData.xPos, _tileData.zPos] = _tileData;
        }

        private void UpdateData()
        {
            _tileData = new TileData();
            _tileData.tileOverhead = gameObject;

            _tileData.xPos = Mathf.FloorToInt(gameObject.transform.position.x);
            _tileData.zPos = Mathf.FloorToInt(gameObject.transform.position.z);

            _tileData.occupiedState = Enums.OccupiedState.empty;
            _tileData.occupiedState = Enums.OccupiedState.empty;
        }
    }
}
