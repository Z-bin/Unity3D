using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_06 : MonoBehaviour {

    Vector2 scrollPosition;

	// Use this for initialization
	void Start ()
    {
        scrollPosition[0] = 50;
        scrollPosition[1] = 50;
	}
	
	// Update is called once per frame
	void Update ()
    {
      
    }
    private void OnGUI()
    {
          scrollPosition = GUI.BeginScrollView(new Rect(0, 0, 200, 200), scrollPosition, 
              new Rect(0, 0, Screen.width, 300), true, true);

        GUI.Label(new Rect(100, 40, Screen.width, 30), "测试滚动视图，测试滚动视图，测试滚动视图，测试滚动视图。");

        //设置结束滚动视图
        GUI.EndScrollView();
    }
}
