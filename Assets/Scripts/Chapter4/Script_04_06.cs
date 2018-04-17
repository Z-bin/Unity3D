using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_06 : MonoBehaviour {
    public GameObject obj;

	// Use this for initialization
	void Start () {
        obj = GameObject.Find("Sphere");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if (GUILayout.Button("开始克隆实例", GUILayout.Height(50)))
        {
            GameObject clone = Instantiate(obj, obj.transform.position, obj.transform.rotation);
            Destroy(clone, 5);
        }
    }
}
