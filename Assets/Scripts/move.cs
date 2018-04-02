using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    int TranslateSpeed = 20;
    int RotateSpeed = 100;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        GUI.backgroundColor = Color.red;
        if (GUI.Button(new Rect(10, 10, 70, 30), "向左旋转"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * (-RotateSpeed));
        }

        if (GUI.Button(new Rect(90, 10, 70, 30), "向前移动"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * (TranslateSpeed));
        }

        if (GUI.Button(new Rect(170, 10, 70, 30), "向右旋转"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * (RotateSpeed));
        }

        if (GUI.Button(new Rect(90, 50, 70, 30), "向后移动"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * (-TranslateSpeed));
        }

        if (GUI.Button(new Rect(10, 50, 70, 30), "向左移动"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * (-TranslateSpeed));
        }

        if (GUI.Button(new Rect(170, 50, 70, 30), "向右移动"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * (TranslateSpeed));
        }

        GUI.Label(new Rect(250, 10, 200, 30), "模型的位置" + transform.position);
        GUI.Label(new Rect(250, 50, 200, 30), "模型的旋转" + transform.rotation);

    }
}
