using System;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Serialization;

public class CellVisualization : MonoBehaviour {

    public GameObject aliveCell;
    public GameObject deadCell;

    [SerializeField, HideInInspector]
    private bool isAlive = true;

    public bool IsAlive {
        get => isAlive;
        set {
            isAlive = value;
            aliveCell.SetActive(isAlive);
            deadCell.SetActive(!isAlive);
        }
    }

    public void Revive() {
        IsAlive = true;
    }

    public void Kill() {
        IsAlive = false;
    }

    private void Start() {
        Assert.IsNotNull(aliveCell);
        Assert.IsNotNull(deadCell);

        if (IsAlive) {
            Revive();
        } else {
            Kill();
        }
    }
}