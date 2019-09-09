﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("2"))
        {
            this.transform.position = new Vector3(100, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;

            #else
                Application.Quit();

            #endif
        }

        if(Input.GetKeyDown("1"))
        {
            this.transform.position = new Vector3(0, 1, 0);
        }
    }
}
