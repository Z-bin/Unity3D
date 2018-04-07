using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 绘制贴图 
 */
public class Script_03_18 : MonoBehaviour
{
    private Texture2D textSingle;
    private Object[] texAll;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 10, 100, 50), "加载一张贴图"))
        {
            if (textSingle == null)
            {
                textSingle = Resources.Load<Texture2D>("0");
            }
        }

        if (GUI.Button(new Rect(0, 130, 100, 50), "加载一组贴图"))
        {
            if (texAll == null)
            {
                texAll = Resources.LoadAll("textures");
            }
        }

        if (textSingle != null)
        {
            GUI.DrawTexture(new Rect(110, 10, 120, 120), textSingle, ScaleMode.StretchToFill, true);
        }

        if (texAll != null)
        {
            for (var i = 0; i < texAll.Length; i++)
            {
                //循环遍历绘制贴图
                GUI.DrawTexture(new Rect(110 + i * 120, 130, 120, 120), (Texture2D)texAll[i], ScaleMode.StretchToFill, true, 0);
            }
        }
    }
}
