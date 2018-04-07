using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_13 : MonoBehaviour {

    public Texture2D texture;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUILayout.BeginHorizontal();
        GUILayout.Box("开始水平布局");
        GUILayout.Button("按钮");
        GUILayout.Label("文本框");
        GUILayout.TextField("输入框");
        GUILayout.Box(texture);
        //结束水平线性局部
        GUILayout.EndHorizontal();


        //开始垂直线性布局
        GUILayout.BeginVertical();
        GUILayout.Box("开始垂直布局");
        GUILayout.Button("按钮");
        GUILayout.Label("文本框");
        GUILayout.TextField("输入框");
        GUILayout.Box(texture);
        //结束垂直线性局部
        GUILayout.EndVertical();

    }
}
