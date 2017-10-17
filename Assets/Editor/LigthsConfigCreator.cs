using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class LigthsConfigCreator {

    [MenuItem("utilities/create Light Config")]
    public static void CreateLightConfig(){
        ScriptableObjectUtility.CreateAsset<LightsConfig>();
    }
}
