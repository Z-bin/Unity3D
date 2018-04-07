using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 控件偏移
 */
public class Script_03_14 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, 200, 60));
        GUILayout.BeginHorizontal();
        GUILayout.BeginVertical();
        GUILayout.Box("test1");

        GUILayout.Space(10);
        GUILayout.Box("test2");
        GUILayout.EndVertical();
        //两个纵向布局中间偏移20像素
        GUILayout.Space(20);
        //嵌套一个纵向布局
        GUILayout.BeginVertical();
        GUILayout.Box("Test3");

        //两个box中间偏移10像素
        GUILayout.Space(10);
        GUILayout.Box("Test4");
        //结束嵌套的纵向局部
        GUILayout.EndVertical();

        //结束最外层横向布局
        GUILayout.EndHorizontal();
        //结束显示区域
        GUILayout.EndArea();
    }
}
