using UnityEngine;

public interface IGameOfLifeProcessor {

    void GenerateNextIteration();

    bool IsCellAlive(int xIndex, int yIndex, int zIndex);
}