﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_16 : MonoBehaviour {

    bool isRotation = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isRotation)
        {
            gameObject.transform.rotation = Quaternion.Slerp
                (gameObject.transform.rotation, Quaternion.Euler(0.0f, 50.0f, 0.0f),
                Time.time * 0.1f);
        }
	}
    private void OnGUI()
    {
        if(GUILayout.Button("旋转固定角度",GUILayout.Height(50)))
        {
            gameObject.transform.rotation = Quaternion.Euler(0.0f, 50.0f, 0.0f);
        }
        if (GUILayout.Button("插值旋转固定角度", GUILayout.Height(50)))
        {
            isRotation = true;
        }
    }
}
