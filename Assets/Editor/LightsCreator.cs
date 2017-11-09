using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Threading;

public class LightsCreator : EditorWindow
{
    string name;
    float bounceintensity;
    float spot;
    float intensity;
    Color color;
    

    [MenuItem("utilities/create Light")]
    static void CreateWindow() // Crea la ventana a mostrar
    {
        ((LightsCreator)GetWindow(typeof(LightsCreator))).Show();
    }
    void OnGUI()
    {
        name = EditorGUILayout.TextField("Name", name);
        bounceintensity = EditorGUILayout.FloatField("Bounce Intencity", bounceintensity);
        spot = EditorGUILayout.FloatField("Spot Angle", spot);
        intensity = EditorGUILayout.FloatField("Intensidad", intensity);
        color = EditorGUILayout.ColorField("color", color);
        Rect rectOpenNew = EditorGUILayout.BeginHorizontal("Button");
        if (GUI.Button(rectOpenNew, GUIContent.none))
        {
            LightsConfig lc = ScriptableObjectUtility.CreateAssetAndReturn<LightsConfig>();
            lc.name = name;
            lc.bounceIntencity = bounceintensity;
            lc.spotValor = spot;
            lc.intensity = intensity;
            lc.color = color;


        }

        GUILayout.Label("create light");
        EditorGUILayout.EndHorizontal();

    }

}