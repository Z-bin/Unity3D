using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_11 : MonoBehaviour {

    private float ScaleX= 1.0f;
    private float ScaleY = 1.0f;
    private float ScaleZ = 1.0f;

    private GameObject obj;
    // Use this for initialization
    void Start () {
        obj = GameObject.Find("Cube");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUILayout.Label("X轴缩放");
        ScaleX = GUILayout.HorizontalSlider(ScaleX, 1.0f, 2.0f, GUILayout.Width(100));
        GUILayout.Label("Y轴缩放");
        ScaleY = GUILayout.HorizontalSlider(ScaleY, 1.0f, 2.0f, GUILayout.Width(100));
        GUILayout.Label("Z轴缩放");
        ScaleZ = GUILayout.HorizontalSlider(ScaleZ, 1.0f, 2.0f, GUILayout.Width(100));
        obj.transform.localScale = new Vector3(ScaleX, ScaleY, ScaleZ);
    }
}
