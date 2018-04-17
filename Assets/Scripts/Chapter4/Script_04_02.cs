using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_02 : MonoBehaviour
{
    private GameObject objCube;
    private GameObject objSphere;
    private bool isCubeRoate;
    private bool isSphereRoate;

    private string CubeInfo = "旋转立方体";
    private string SphereInfo = "旋转球体";

    // Use this for initialization
    void Start ()
    {
        objCube = GameObject.Find("Cube");
        objSphere = GameObject.Find("Object/Sphere");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(isCubeRoate)
        {
            if(objCube)
            {
                objCube.transform.Rotate(0.0f, Time.deltaTime * 200, 0.0f);
            }
        }
        if (isSphereRoate)
        {
            if (objSphere)
            {
                objSphere.transform.Rotate(0.0f, Time.deltaTime * 200, 0.0f);
            }
        }
    }

    private void OnGUI()
    {
        if(GUILayout.Button(CubeInfo, GUILayout.Height(50)))
        {
            if(!isCubeRoate)
            {
                isCubeRoate = true;
                CubeInfo = "停止旋转立方体";
            }
            else
            {
                isCubeRoate = false;
                CubeInfo = "旋转立方体";
            }
        }

        if (GUILayout.Button(SphereInfo, GUILayout.Height(50)))
        {
            if (!isSphereRoate)
            {
                isSphereRoate = true;
                SphereInfo = "停止旋球体";
            }
            else
            {
                isSphereRoate = false;
                SphereInfo = "旋转球体";
            }
        }

        if(GUILayout.Button("销毁模型", GUILayout.Height(50)))
        {
            Destroy(objCube);
            Destroy(objSphere);
        }

    }


}
