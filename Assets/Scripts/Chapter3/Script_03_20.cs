using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_20 : MonoBehaviour {

    private Object[] animUp;
    private Object[] animDown;
    private Object[] animLeft;
    private Object[] animRight;
    private Object[] tex;

    private Texture2D map;

    private int x;
    private int y;
    private int nowFram;
    private int mFramCount;
    private float fps = 10.0f;
    private float time = 0.0f;
    
    // Use this for initialization
    void Start ()
    {
        //加载图片资源
        animUp = Resources.LoadAll("up");
        animDown = Resources.LoadAll("down");
        animLeft = Resources.LoadAll("left");
        animRight = Resources.LoadAll("right");

        map = Resources.Load<Texture2D>("map/map");
        tex = animUp;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), map, ScaleMode.StretchToFill, true);

        DrawAnimation(tex, new Rect(x, y, 32, 48));

        //点击按钮移动人物
        if (GUILayout.RepeatButton("向上"))
        {
            y -= 2;
            tex = animUp;
        }
        if (GUILayout.RepeatButton("向下"))
        {
            y += 2;
            tex = animDown;
        }
        if (GUILayout.RepeatButton("向左"))
        {
            x -= 2;
            tex = animLeft;
        }
        if (GUILayout.RepeatButton("向右"))
        {
            x += 2;
            tex = animRight;
        }
    }

    private void DrawAnimation(Object[] tex, Rect rect)
    {
        //绘制当前帧
        GUI.DrawTexture(rect, (Texture)tex[nowFram], ScaleMode.StretchToFill, true, 0);
        //计算限制帧时间
        time += Time.deltaTime;
        //超过限制帧则切换图片
        if (time >= 1.0 / fps)
        {
            //帧序列切换
            nowFram++;
            //限制帧清空
            time = 0;
            //超过帧动画总数从第0帧开始
            if (nowFram >= tex.Length)
            {
                nowFram = 0;
            }
        }
    }
}
