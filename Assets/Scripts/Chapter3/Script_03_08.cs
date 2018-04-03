using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 窗口
 */
 
public class Script_03_08 : MonoBehaviour
{

    private Rect window0 = new Rect(20, 20, 200, 200);
    private Rect window1 = new Rect(250, 20, 200, 200);

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
        GUI.Window(0, window0, oneWindow, "第一个窗口");
        GUI.Window(1, window1, twoWindow, "第二个窗口");
    }

    private void oneWindow(int windowID)
    {
        GUI.Box(new Rect(10, 50, 150, 50), "这里窗口的ID是" + windowID);
        if(GUI.Button(new Rect(10, 120, 150, 50), "普通按钮"))
        {
            Debug.Log("窗口ID = " + windowID + "按钮被点击");
        }

    }

    private void twoWindow(int windowID)
    {
        GUI.Box(new Rect(10, 50, 150, 50), "这里窗口的ID是" + windowID);
        if (GUI.Button(new Rect(10, 120, 150, 50), "普通按钮"))
        {
            Debug.Log("窗口ID = " + windowID + "按钮被点击");
        }

    }
}
