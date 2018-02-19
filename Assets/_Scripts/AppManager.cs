using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEditor;
using Assets._Scripts;
using Assets._Scripts.Utilities;
using Assets._Scripts.Characters;
using Assets._Scripts.Tiles;
using Assets._ScriptableObjects;

public class AppManager : MonoBehaviour
{
    [Header("Maximum X Axis Size of the Game Map in Tiles")]
    public int xLength;
    [Header("Maximum Z Axis Size of the Game Map in Tiles")]
    public int zLength;

    public Thread MAIN_THREAD;

    private so_TileContainer _tileContainer;

    private void Awake()
    {
        _tileContainer = gameObject.GetComponent<AppDependencies>().tileContainer;
        _tileContainer.ResetArray();
    }

    private void Start()
    {
        MAIN_THREAD = Thread.CurrentThread;
        MAIN_THREAD.Name = "MAIN_THREAD";
    }
}
