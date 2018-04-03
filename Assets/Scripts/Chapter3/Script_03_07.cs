using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *群组视图
 */
 
public class Script_03_07 : MonoBehaviour
{
    public Texture2D viewTexture0;
    public Texture2D viewTexture1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnGUI()
    {
        GUI.BeginGroup(new Rect(10, 50, 200, 400));
        GUI.DrawTexture(new Rect(10, 20, viewTexture0.width, viewTexture0.height),
            viewTexture1);
        GUI.Label(new Rect(10, 150, 100, 40), "群组视图1");
        GUI.Button(new Rect(10, 190, 100, 40), "按钮");
        GUI.EndGroup();

        GUI.BeginGroup(new Rect(300, 0, 500, 400));
        GUI.DrawTexture(new Rect(10, 20, viewTexture1.width, viewTexture1.height),
            viewTexture1);
        GUI.Label(new Rect(10, 150, 100, 40), "群组视图2");
        GUI.Button(new Rect(10, 190, 100, 40), "按钮");
        GUI.EndGroup();

    }
}

