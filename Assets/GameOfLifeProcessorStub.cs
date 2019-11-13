using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class GameOfLifeProcessorStub : IGameOfLifeProcessor
{
    private bool[,,] _currentIteration;
    private int _xSize;
    private int _ySize;
    private int _zSize;

    public GameOfLifeProcessorStub(bool[,,] seed) {
        _xSize = seed.GetLength(0);
        _ySize = seed.GetLength(0);
        _zSize = seed.GetLength(0);

        _currentIteration = seed;
    }

    public void GenerateNextIteration() {
        // Do nothing
    }

    public bool IsCellAlive(int xIndex, int yIndex, int zIndex) {
        return Random.value > 0.9;
    }
}