using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_21 : MonoBehaviour
{
    private GameObject hero;

    //按键是否按下
    private bool keyUp;
    private bool keyDown;
    private bool keyLeft;
    private bool keyRight;

    private Object[] animUp;
    private Object[] animDown;
    private Object[] animLeft;
    private Object[] animRight;
    private Object[] nowAnim;
    private Object[] backAnim;

    private Texture2D map;

    private int x;
    private int y;
    private int nowFram;
    private int mFramCount;
    private float fps = 10.0f;
    private float time = 0.0f;    

    // Use this for initialization
    void Start()
    {
        //得到主角对象
        hero = GameObject.Find("hero");
        //得到上下左右四组动画
        animUp = Resources.LoadAll("up");
        animDown = Resources.LoadAll("down");
        animLeft = Resources.LoadAll("left");
        animRight = Resources.LoadAll("right");   
        
        nowAnim = animDown;
        backAnim = animDown;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        
        keyUp = GUILayout.RepeatButton("向上");
        keyDown = GUILayout.RepeatButton("向下");
        keyLeft = GUILayout.RepeatButton("向左");
        keyRight = GUILayout.RepeatButton("向右");
    }

    //控制移动
    private void FixedUpdate()
    {
        if(keyUp)
        {
            SetAnimation(animUp);
            hero.transform.Translate(-Vector3.forward * 0.001f);
        }

        if (keyDown)
        {
            SetAnimation(animDown);
            hero.transform.Translate(Vector3.forward * 0.001f);
        }

        if (keyLeft)
        {
            SetAnimation(animLeft);
            hero.transform.Translate(Vector3.right * 0.001f);
        }

        if (keyRight)
        {
            SetAnimation(animRight);
            hero.transform.Translate(-Vector3.right * 0.001f);
        }
        DrawAnimation(nowAnim);
    }

    private void DrawAnimation(Object[] tex)
    {                
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
        //将贴图给予对象
        hero.GetComponent<Renderer>().material.mainTexture = (Texture2D)tex[nowFram];        
    }

    private void SetAnimation(Object[] tex)
    {
        nowAnim = tex;
        if (!backAnim.Equals(nowAnim))
        {            
            nowFram = 0;
            backAnim = nowAnim;
        }
    }
}
