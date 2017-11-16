using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LightsConfig))]
public class LightConfigEditor : Editor
{
    public options op;
    private LightsConfig _target;

    private void OnEnable()
    {
        _target = (LightsConfig)target;
    }
    public override void OnInspectorGUI()
    {
        _target.name = EditorGUILayout.TextField("Name", _target.name);
        op = (options)EditorGUILayout.EnumPopup("Light Type", op);
		_target.bounceIntencity = EditorGUILayout.FloatField ("Bounce Intencity",_target.bounceIntencity);
		_target.spotValor = EditorGUILayout.FloatField ("Spot Angle", _target.spotValor);
		_target.intensity = EditorGUILayout.FloatField ("Intensidad", _target.intensity);
		_target.color = EditorGUILayout.ColorField ("color", _target.color);
        instantiateop(op);

    }
    void instantiateop(options op)
    {
        switch (op)
        {
            case options.Spot:
                _target.type = LightType.Spot;
                break;
            case options.Directional:
                _target.type = LightType.Directional;
                break;
            case options.Point:
                _target.type = LightType.Point;
                break;
            case options.Area:
                _target.type = LightType.Area;
                break;
        }
    }
    public enum options
    {
      Spot = 0,
      Directional = 1,
      Point = 2,
      Area = 3
    }
}

