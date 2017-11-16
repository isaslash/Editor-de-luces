using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Light))]
public class LightEditor : Editor {

    public LightsConfig data;
    private Light _target;

    private void OnEnable()
    {
        _target = (Light)target;
        
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        data = (LightsConfig)EditorGUILayout.ObjectField("Config", data, typeof(LightsConfig), true);
        if(data!= null)
        {
            if (GUI.changed)
            {
                _target.intensity = data.intensity;
                _target.color = data.color;
                _target.spotAngle = data.spotValor;
                _target.bounceIntensity = data.bounceIntencity;
                _target.type = data.type;
            }
        }
    }

}
