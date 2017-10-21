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
		EditorGUILayout.LabelField ("configuracion de luces", EditorStyles.boldLabel);
        _target.name = EditorGUILayout.TextField("Name", _target.name);
		_target.bounceIntencity = EditorGUILayout.FloatField ("Bounce Intencity",_target.bounceIntencity);
		_target.spotValor = EditorGUILayout.FloatField ("Spot Angle", _target.spotValor);
		_target.intensity = EditorGUILayout.FloatField ("Intencidad", _target.intensity);
		_target.color = EditorGUILayout.ColorField ("color", _target.color);

		//_target.spotValor = EditorGUILayout.Slider ("spotAngle", _target.spotValor, 0, 100);
		//EditorGUI.ProgressBar (GUILayoutUtility.GetRect (15, 15, "textField"), _target.spotValor / 100, _target.spotValor + "%");
    }
}

