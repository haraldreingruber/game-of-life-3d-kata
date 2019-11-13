using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CellVisualization))]
public class CellInspector : Editor {
    public override void OnInspectorGUI() {
        DrawDefaultInspector();

        CellVisualization cellVisualization = (CellVisualization) target;

        if (GUILayout.Button("Revive"))
            cellVisualization.Revive();
        if (GUILayout.Button("Kill"))
            cellVisualization.Kill();
    }
}