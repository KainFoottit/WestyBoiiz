using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Assets._Scripts;
using Assets._Scripts.Utilities;
using Assets._Scripts.Characters;
using Assets._Scripts.Tiles;

public class Pathfinder
{
    private TileData _startTile;
    private TileData _destinationTile;
    private TileData[,] _tileArray;

    private int _moveCost;

    /// <summary>
    /// Constructor for the Pathfinder, calculates movement cost of going between two tiles
    /// </summary>
    /// <param name="startTile">
    /// The first tile to calculate movement from
    /// </param>
    /// <param name="destinationTile">
    /// The tile to calculate movement to
    /// </param>
    /// <param name="tileList">
    /// Master container of tiles store in so_TileContainer
    /// </param>
    public Pathfinder(TileData startTile, TileData destinationTile, TileData[,] tileArray, int moveCost)
    {
        _startTile = startTile;
        _destinationTile = destinationTile;
        _tileArray = tileArray;
        _moveCost = moveCost;

        ThreadStart calculateRef = new ThreadStart(Calculate);
        Thread calculateChild = new Thread(calculateRef);
        calculateChild.Start();
    }

    private void Calculate()
    {
        //game is built around 2x2 squares, base move cost per square is 1
        int xCrd = _startTile.xPos;
        int zCrd = _startTile.zPos;

        bool calculated = false;
        do
        {
            int xDist = Math.Abs(_destinationTile.zPos - xCrd);
            int zDist = Math.Abs(_destinationTile.xPos - zCrd);

            if (xDist + zDist > _moveCost)
            {
                Debug.Log("Requested movement exceeds move cost. X Distance = " + xDist +
                    ", Z Distance = " + zDist +
                    ", Move Cost = " + _moveCost);
                return;
            }
        }
        while (calculated == false);        
    }

    /// <summary>
    /// Switches on TilePassability to alter movement cost of tile
    /// </summary>
    /// <param name="passability">
    /// TilePassability from TileData variable
    /// </param>
    /// <returns>
    /// Int modifier of movement cost
    /// </returns>
    private int Passability(Enums.TilePassability passability)
    {
        int output = 0;

        switch (passability)
        {
            case Enums.TilePassability.empty:
                output = 0;
                break;
            case Enums.TilePassability.door:
            case Enums.TilePassability.stairs:
                output = 1;
                break;
            case Enums.TilePassability.water:
                output = 2;
                break;
        }

        return output;
    }

    private float DistanceCoord(TileData start, TileData destination)
    {
        float xDist = Math.Abs(destination.xPos - start.xPos);
        float zDist = Math.Abs(destination.zPos - start.zPos);

        return -1f;
    }

    private float DistancePythag(TileData start, TileData destination)
    {
        float xDist = Math.Abs(destination.xPos - start.xPos);
        float zDist = Math.Abs(destination.zPos - start.zPos);

        return (float)(Math.Sqrt(Math.Pow(xDist, 2) + Math.Pow(zDist, 2)));
    }
}
