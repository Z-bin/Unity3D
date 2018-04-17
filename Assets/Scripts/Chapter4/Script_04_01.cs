using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_01 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnGUI()
    {
        if(GUILayout.Button("创建立方体", GUILayout.Height(50)))
        {
            GameObject objCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objCube.AddComponent<Rigidbody>();
            objCube.name = "Cube";
            //设置模型材质
            objCube.GetComponent<MeshRenderer>().material.color = Color.blue;
            objCube.transform.position = new Vector3(0.0f, 10.0f, 0.0f);
        }
        if (GUILayout.Button("创建球体", GUILayout.Height(50)))
        {
            GameObject objCube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            objCube.AddComponent<Rigidbody>();
            objCube.name = "Sphere";
            //设置模型材质
            objCube.GetComponent<MeshRenderer>().material.color = Color.red;
            objCube.transform.position = new Vector3(0.0f, 10.0f, 0.0f);
        }
    }
}
