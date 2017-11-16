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
    options op;
    LightsConfig lc;
    Light newlight;

    [MenuItem("utilities/create Light")]
    static void CreateWindow() // Crea la ventana a mostrar
    {
        ((LightsCreator)GetWindow(typeof(LightsCreator))).Show();
    }
    void OnGUI()
    {
        name = EditorGUILayout.TextField("Name", name);
        op = (options)EditorGUILayout.EnumPopup("Light Type", op);
        bounceintensity = EditorGUILayout.FloatField("Bounce Intencity", bounceintensity);
        spot = EditorGUILayout.FloatField("Spot Angle", spot);
        intensity = EditorGUILayout.FloatField("Intensidad", intensity);
        color = EditorGUILayout.ColorField("color", color);
        Rect rectOpenNew = EditorGUILayout.BeginHorizontal("Button");
        
        if (GUI.Button(rectOpenNew, GUIContent.none))
        {
            lc = ScriptableObjectUtility.CreateAssetAndReturn<LightsConfig>();
            lc.name = name;
            lc.bounceIntencity = bounceintensity;
            lc.spotValor = spot;
            lc.intensity = intensity;
            lc.color = color;
            instantiateop(op);
            GameObject light = new GameObject(name);
            light.AddComponent<Light>();
            light.GetComponent<Light>().bounceIntensity = bounceintensity;
            light.GetComponent<Light>().spotAngle = spot;
            light.GetComponent<Light>().intensity = intensity;
            light.GetComponent<Light>().color = color;

        }

        GUILayout.Label("create light");
        EditorGUILayout.EndHorizontal();
    }
    void instantiateop(options op)
    {
        switch (op)
        {
            case options.Spot:
                lc.type = LightType.Spot;
                break;
            case options.Directional:
                lc.type = LightType.Directional;
                break;
            case options.Point:
                lc.type = LightType.Point;
                break;
            case options.Area:
                lc.type = LightType.Area;
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