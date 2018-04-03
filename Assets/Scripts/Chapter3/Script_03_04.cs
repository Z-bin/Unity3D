using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_04 : MonoBehaviour
{
    private int select;
    string[] barResource = { "第一个工具栏", "第二个工具", "第三个工具栏", "第四个工具栏" };
    private bool selecetToogle0;
    private bool selecetToogle1;

    // Use this for initialization
    void Start ()
    {
        select = 0;

        selecetToogle0 = false;
        selecetToogle1 = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
       
	}

    private void OnGUI()
    {
        int oldSelect = select;
        select = GUI.Toolbar(new Rect(10, 10, barResource.Length * 100, 30), select, barResource);
     //   Debug.Log(select);

        if (oldSelect != select)
        {
            selecetToogle0 = false;
            selecetToogle1 = false;
        }

        switch (select)
        {
            case 0:
                selecetToogle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selecetToogle0, "第一个菜单选择1");
                selecetToogle1 = GUI.Toggle(new Rect(10, 80, 150, 30), selecetToogle1, "第一个菜单选择2");
                break;
            case 1:
                selecetToogle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selecetToogle0, "第一个菜单选择1");
                selecetToogle1 = GUI.Toggle(new Rect(10, 80, 150, 30), selecetToogle1, "第一个菜单选择2");
                break;
            case 2:
                selecetToogle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selecetToogle0, "第一个菜单选择1");
                selecetToogle1 = GUI.Toggle(new Rect(10, 80, 150, 30), selecetToogle1, "第一个菜单选择2");
                break;
            case 3:
                selecetToogle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selecetToogle0, "第一个菜单选择1");
                selecetToogle1 = GUI.Toggle(new Rect(10, 80, 150, 30), selecetToogle1, "第一个菜单选择2");
                break;


        }
    }
}
