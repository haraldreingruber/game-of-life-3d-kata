using System;
using UnityEngine;
using UnityEngine.Assertions;

public class GridVisualization : MonoBehaviour {
    public CellVisualization cellPrefab;
    
    public int xSize;
    public int ySize;
    public int zSize;

    private IGameOfLifeProcessor _processor;

    private const double IterationTime = 2.0;

    private CellVisualization[,,] _cellVisualizations;

    private double _lastIterationTime;
    private int _iterationCounter = 0;

    // Start is called before the first frame update
    private void Start() {
        Assert.IsNotNull(cellPrefab);

        var seed = new bool[xSize, ySize, zSize];
        _processor = new GameOfLifeProcessorStub(seed);
        InstantiateCells();
    }

    private void InstantiateCells() {
        _cellVisualizations = new CellVisualization[xSize, ySize, zSize];

        for (int xIndex = 0; xIndex < xSize; xIndex++) {
            for (int yIndex = 0; yIndex < ySize; yIndex++) {
                for (int zIndex = 0; zIndex < zSize; zIndex++) {
                    var cell = GameObject.Instantiate(
                        cellPrefab,
                        this.transform);

                    cell.transform.localPosition = new Vector3(
                        xIndex - xSize / 2.0f,
                        yIndex - ySize / 2.0f,
                        zIndex - zSize / 2.0f);

                    _cellVisualizations[xIndex, yIndex, zIndex] = cell;
                }
            }
        }
    }

    // Update is called once per frame
    private void Update() {
        if (Time.time < _lastIterationTime + IterationTime)
            return;

        _lastIterationTime = Time.time;

        _iterationCounter++;
        Debug.Log($"Computing Iteration: {_iterationCounter} ");
        _processor.GenerateNextIteration();
        UpdateVisualization();
    }

    private void UpdateVisualization() {
        for (int xIndex = 0; xIndex < xSize; xIndex++) {
            for (int yIndex = 0; yIndex < ySize; yIndex++) {
                for (int zIndex = 0; zIndex < zSize; zIndex++) {
                    var cellVisualization = _cellVisualizations[xIndex, yIndex, zIndex];

                    var isCellAlive = _processor.IsCellAlive(xIndex, yIndex, zIndex);
                    if (isCellAlive)
                        cellVisualization.Revive();
                    else {
                        cellVisualization.Kill();
                    }
                }
            }
        }
    }
}