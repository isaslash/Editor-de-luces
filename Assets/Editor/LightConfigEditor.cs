using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LightsConfig))]
public class LightsEditor : Editor
{
    private LightsConfig _target;

    private void OnEnable()
    {
        _target = (LightsConfig)target;
    }
    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();
        _target.name = EditorGUILayout.TextField("Name", _target.name);


    }
}

