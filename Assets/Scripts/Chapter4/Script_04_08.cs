using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_08 : MonoBehaviour {
    private float Value_X = 0.0f;
    private float Value_Y = 0.0f;
    private float Value_Z = 0.0f;

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
        GUILayout.Box("移动立方体X轴");
        Value_X = GUILayout.HorizontalSlider(Value_X, -10.0f, 10.0f, GUILayout.Width(200));
        GUILayout.Box("移动立方体Y轴");
        Value_Y = GUILayout.HorizontalSlider(Value_Y, -10.0f, 10.0f, GUILayout.Width(200));
        GUILayout.Box("移动立方体Z轴");
        Value_Z = GUILayout.HorizontalSlider(Value_Z, -10.0f, 10.0f, GUILayout.Width(200));

        obj.transform.position = new Vector3(Value_X, Value_Y, Value_Z);
        GUILayout.Label("立方体当前位置: " + obj.transform.position);
    }
}
