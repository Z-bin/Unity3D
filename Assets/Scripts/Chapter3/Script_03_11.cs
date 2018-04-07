using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_11 : MonoBehaviour
{
    private string addStr = "添加测试字符串";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if(GUI.Button(new Rect(50, 50, 100, 30), addStr))
        {
            addStr += addStr;
        }
        if(GUILayout.Button(addStr))
        {
            addStr += addStr; 
        }
    }
}
