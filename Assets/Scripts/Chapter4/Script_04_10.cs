using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_10 : MonoBehaviour {

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
        if(GUILayout.Button("向前移动", GUILayout.Height(50)))
        {
            obj.transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (GUILayout.Button("向后移动", GUILayout.Height(50)))
        {
            obj.transform.Translate(-Vector3.forward * Time.deltaTime);
        }
        if (GUILayout.Button("向左移动", GUILayout.Height(50)))
        {
            obj.transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (GUILayout.Button("向右移动", GUILayout.Height(50)))
        {
            obj.transform.Translate(Vector3.right * Time.deltaTime);
        }

        GUILayout.Label("位置: " + obj.transform.position);
    }
}
