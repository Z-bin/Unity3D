using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_03 : MonoBehaviour
{         
    // Use this for initialization
    void Start ()
    {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("MyTag");
        objs[2].tag = "TestTag";

        for (int i = 0; i < objs.Length; i++)
        {
            Debug.Log("以" + objs[i].tag + "标签为游戏对象的名称 " + objs[i].name);
            if (objs[i].tag == "TestTag")
            {
                Debug.Log("这个标签为TestTag");
            }

            //判断该游戏对象是否包含TestTag这个标签
            if (objs[i].CompareTag("TestTag"))
            {
                Debug.Log("obj这个对象附带的标签为TestTag");
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
