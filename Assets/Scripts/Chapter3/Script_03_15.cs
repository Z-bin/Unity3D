using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_15 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        //开始最外层横向布局
        GUILayout.BeginHorizontal();
        //嵌套一个纵向布局
        GUILayout.BeginVertical();

        GUILayout.Box("Test1");
        //两个box之间上下对齐
        GUILayout.FlexibleSpace();
        GUILayout.Box("Test2");
        //结束嵌套的纵向局部
        GUILayout.EndVertical();

        //布局之间左右对齐
        GUILayout.FlexibleSpace();

        //嵌套一个纵向布局
        GUILayout.BeginVertical();

        GUILayout.Box("Test3");
        //两个box之间上下对齐
        GUILayout.FlexibleSpace();
        GUILayout.Box("Test4");
        //结束嵌套的纵向局部
        GUILayout.EndVertical();

        //结束最外层横向布局
        GUILayout.EndHorizontal();
        //结束显示区域
        GUILayout.EndArea();
    }
}
