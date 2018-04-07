using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_09 : MonoBehaviour
{
    GUISkin mySkin;
    bool choose = false;
    Rect windowRect= new Rect(20, 20, 120, 50);
    private string edit = "输入字符串";

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnGUI()
    {
        GUI.skin = mySkin;
        GUI.Button(new Rect(100, 100, 100, 100), "自定义按钮");
        choose = GUI.Toggle(new Rect(10, 50, 100, 30), choose, "单项选择");
        edit = GUI.TextField(new Rect(200, 10, 200, 20), edit, 25);
        windowRect = GUI.Window(0, windowRect, setWindow, "这是一个窗口");
    }

    private void setWindow(int windowID)
    {
        GUI.DragWindow();
        GUI.Button(new Rect(10, 20, 100, 30), "自定义按钮");
    }

}
