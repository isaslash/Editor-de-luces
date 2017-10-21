using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class MyLight : MonoBehaviour {

	public LightsConfig data;
	public Light luz;



	void Start () 
	{
		luz = this.GetComponent<Light>();
	}
	
	void Update()
	{
		
		if (Application.isEditor)
		{	
			luz.intensity = data.intensity;
			luz.color = data.color;
			luz.spotAngle = data.spotValor;
			luz.bounceIntensity = data.bounceIntencity;
			luz.type = data.type;
			print ("asddassda");
	}
	}
}
