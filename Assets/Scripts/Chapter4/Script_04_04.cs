using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_04 : MonoBehaviour
{
    public Texture texture;
    private GameObject obj;
    private Renderer render;
    
	// Use this for initialization
	void Start ()
    {
        obj = GameObject.Find("Cube");
        //获得对象的渲染器
        render = (Renderer)obj.GetComponent("Renderer");
	}
	
	// Update is called once per frame
	void Update ()
    {
	    	
	}

    private void OnGUI()
    {
        if(GUILayout.Button("添加颜色", GUILayout.Width(100), GUILayout.Height(50)))
        {
            render.material.color = Color.green;
            render.material.mainTexture = null;
        }
        if(GUILayout.Button("添加贴图", GUILayout.Width(100), GUILayout.Height(50)))
        {
            render.material = null;
            render.material.mainTexture = texture;
        }

    }
}
