using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_22 : MonoBehaviour {

    private Texture2D bg;
    private Texture2D title;
    private Object[] tex;

    private int x;
    private int y;
    private int nowFram;
    private int mFramCount;
    private float fps = 5.0f;
    private float time = 0.0f;



    // Use this for initialization
    void Start ()
    {
        bg = (Texture2D)Resources.Load("picture/bg");
        title = (Texture2D)Resources.Load("picture/title");
        tex = Resources.LoadAll("anim");

        x = Screen.width;
        y = 200;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), bg, ScaleMode.StretchToFill, true, 0);
        GUI.DrawTexture(new Rect((Screen.width - title.width) >> 1, 30, title.width, title.height), title, ScaleMode.StretchToFill, true, 0);

        DrawAnimation(tex, new Rect(x, y, 40, 60));
        //动画越界监测
        x--;
        if (x < -42)
        {
            x = 480;

        }
        //绘制按钮
        GUI.Button(new Rect(230, 200, 100, 30), "开始游戏");
        GUI.Button(new Rect(230, 240, 100, 30), "读取进度");
        GUI.Button(new Rect(230, 280, 100, 30), "关于游戏");
        GUI.Button(new Rect(230, 320, 100, 30), "退出游戏");
    }

    private void DrawAnimation(object[] tex, Rect rect)
    {
        GUI.DrawTexture(rect, (Texture)tex[nowFram], ScaleMode.StretchToFill, true);
        time += Time.deltaTime;
        if(time >= 1.0 / fps)
        {
            nowFram++;
            time = 0;
            if(nowFram >= tex.Length)
            {
                nowFram = 0;
            }
        }
    }
}
