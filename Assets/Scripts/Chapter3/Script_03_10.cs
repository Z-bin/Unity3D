using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_10 : MonoBehaviour
{
    public GUISkin mySkin;
    public float horizontalValue = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.skin = mySkin;
        GUI.Button(new Rect(0, 100, 256, 49), "", "custom0");
        GUI.Button(new Rect(300, 100, 256, 49), "", "custom1");

        horizontalValue = GUI.HorizontalSlider(new Rect(50, 25, 382, 50), horizontalValue, 0.0f, 100.0f);
        GUI.Button(new Rect(300, 200, 191, 176), "");
    }
}
