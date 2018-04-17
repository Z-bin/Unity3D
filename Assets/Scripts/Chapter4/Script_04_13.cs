using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_13 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUILayout.Label("当前游戏时间 " + Time.time);
        GUILayout.Label("上一帧消耗时间 " + Time.time);
        GUILayout.Label("固定增量时间 " + Time.fixedTime);
        GUILayout.Label("上一帧固定增量时间 " + Time.fixedDeltaTime);

    }
}
