using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_16 : MonoBehaviour {

    public Texture icon;
    private ArrayList winArrayList = new ArrayList();
//    public Rect windowRect = new Rect(20, 20, 120, 50);

    // Use this for initialization
    void Start ()
    {
        winArrayList.Add(new Rect(winArrayList.Count * 100, 50, 150, 100));
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnGUI()
    {
        
        int count = winArrayList.Count;
        for(int i = 0; i < count; i++)
        {
            //winArrayList[i] = GUILayout.Window(i, winArrayList[i], AddWindow, "窗口ID" + i);
            winArrayList[i] = GUILayout.Window(i, new Rect(100, 100, 100, 100), AddWindow, "窗口ID：" + i);
        }
       
     //   windowRect = GUI.Window(0, windowRect, AddWindow, "My Window");
    }

    private void AddWindow(int windowID)
    {
        
        //开始一个水平布局
        GUILayout.BeginHorizontal();
        //绘制图标
        GUILayout.Label(icon, GUILayout.Width(50), GUILayout.Height(50));
        //绘制文字
        GUILayout.Label("这是一个全新的窗口");
        //关闭水平布局
        GUILayout.EndHorizontal();

        //开始一个水平布局
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("添加新窗口"))
        {
            //添加窗口
            winArrayList.Add(new Rect(winArrayList.Count * 100, 50, 150, 100));
        }

        if (GUILayout.Button("关闭当前窗口"))
        {
            //关闭窗口
            winArrayList.RemoveAt(windowID);
        }
        //关闭水平布局
        GUILayout.EndHorizontal();
        //设置窗口拖动的区域
        
        GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));

    }
}
