using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_09 : MonoBehaviour {

    private GameObject objectCube;
    private GameObject objCylinder;
    private int speed = 100;

	// Use this for initialization
	void Start () {
        objectCube = GameObject.Find("Cube");
        objCylinder = GameObject.Find("Cylinder");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if(GUILayout.Button("沿X轴旋转",GUILayout.Height(50)))
        {
            objectCube.transform.Rotate(Vector3.right * Time.deltaTime * speed);
        }
        if (GUILayout.Button("沿Y轴旋转", GUILayout.Height(50)))
        {
            objectCube.transform.Rotate(Vector3.up * Time.deltaTime * speed);
        }
        if (GUILayout.Button("沿Z轴旋转", GUILayout.Height(50)))
        {
            objectCube.transform.Rotate(Vector3.forward * Time.deltaTime * speed);
        }

        if (GUILayout.Button("绕圆柱体旋转", GUILayout.Height(50)))
        {
            objectCube.transform.RotateAround(objCylinder.transform.position,Vector3.up, Time.deltaTime * speed);
        }
        GUILayout.Label("立方体旋转角度" + objectCube.transform.rotation);
    }
}
