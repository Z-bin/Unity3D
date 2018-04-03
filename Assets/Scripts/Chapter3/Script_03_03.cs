using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_03 : MonoBehaviour
{

    // Use this for initialization
    private string editUsername;
    private string editPasseword;
    private string editshow;
	void Start ()
    {
        editshow = "输入用户名与密码";
        editUsername = "输入用户名";
        editPasseword = "输入密码";
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, Screen.width, 30), editshow);
        if(GUI.Button(new Rect(10, 120, 100, 50), "登录"))
        {
            editshow = "用户名为: " + editUsername;
        }

        GUI.Label(new Rect(10, 40, 50, 30), "用户名");
        GUI.Label(new Rect(10, 80, 50, 30), "密码");

        editUsername = GUI.TextField(new Rect(60, 40, 200, 30), editUsername, 15);
        editPasseword = GUI.PasswordField(new Rect(60, 80, 200, 30), editPasseword, "*"[0], 15);
    }
}
