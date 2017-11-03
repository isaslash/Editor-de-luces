using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Threading;

public class LightsCreator : EditorWindow
{
    public LightsCreator config;
    

    [MenuItem("utilities/create Light")]
    static void CreateWindow() // Crea la ventana a mostrar
    {
        ((LightsCreator)GetWindow(typeof(LightsCreator))).Show();
    }

}