using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour {

    public Light light;
    public int i = 0;
	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("tab"))
        {
            Color[] colors = { Color.cyan, Color.magenta, Color.yellow, Color.white }; 
            light.color = colors[(i++)%4];
        }
	}
}
