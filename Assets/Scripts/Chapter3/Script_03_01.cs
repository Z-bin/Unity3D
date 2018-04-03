using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_01 : MonoBehaviour {

    // Use this for initialization
    string str;
    public Texture imageTexture;
    private int imageWidth;
    private int imageHeight;
    private int screenWidth;
    private int screenHeight;

	void Start ()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        imageWidth = imageTexture.width;
        imageHeight = imageTexture.height;           
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnGUI()
    {
        GUI.Label(new Rect(100, 10, 100, 30), str);
        GUI.Label(new Rect(100, 40, 100, 30), "当前屏幕宽" + screenWidth);
        GUI.Label(new Rect(100, 80, 100, 30), "当前屏幕高" + screenHeight);
        GUI.Label(new Rect(100, 120, imageWidth, imageHeight), imageTexture);
    }
}
