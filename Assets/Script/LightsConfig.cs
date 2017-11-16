using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsConfig : ScriptableObject {
	
    public LightType type;
    public Color color;
	public float spotValor;
    public float intensity;
	public Light light;
	public float bounceIntencity;

}
