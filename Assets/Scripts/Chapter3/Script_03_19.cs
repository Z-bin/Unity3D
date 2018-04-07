using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//绘制动画
public class Script_03_19 : MonoBehaviour {

    private Object[] anim;
    private int nowFram;
    private int mFrameCount;
    private float fps = 1;
    private float time = 0;

	// Use this for initialization
	void Start ()
    {
        anim = Resources.LoadAll("animation");
        mFrameCount = anim.Length;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnGUI()
    {
        DrawAnimation(anim, new Rect(100, 100, 32, 48));
    }

    private void DrawAnimation(Object[] tex, Rect rect)
    {
        GUILayout.Label("当前动画播放:第" + nowFram + "帧");
        GUI.DrawTexture(rect, (Texture)tex[nowFram], ScaleMode.StretchToFill, true);
        time += (Time.deltaTime);
        Debug.Log("时间 " + Time.deltaTime);       

        if (time >= 1.0 / fps)
        {
            nowFram++;
            time = 0;
            if (nowFram >= mFrameCount)
            {
                nowFram = 0;
            }
        }



    }
}
