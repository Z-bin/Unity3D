using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_17 : MonoBehaviour {

    public GameObject plane;
    public GameObject cube;

    public Texture map;
    public Texture mapCube;

    //大地图高宽
    float mapWidth;
    float mapHeight;

    //地图边界
    float widthCheck;
    float heightCheck;

    //小地图人物位置
    float mapCube_x = 0;
    float mapCube_y = 0;

    bool keyUp;
    bool keyDown;
    bool keyRight;
    bool keyLeft;

    
    void Start()
    {
        plane = GameObject.Find("Plane");
        cube = GameObject.Find("Cube");
        //原始地图的宽
        float size_x = plane.GetComponent<MeshFilter>().mesh.bounds.size.x;
        //缩放比例
        float scal_x = plane.transform.localScale.x;
        //原始地图高
        float size_z = plane.GetComponent<MeshFilter>().mesh.bounds.size.z;
        //缩放比例
        float scal_z = plane.transform.localScale.z;

        //得到地图真实的大小
        mapWidth = size_x * scal_x;
        mapHeight = size_z * scal_z;

        widthCheck = mapWidth / 2;
        heightCheck = mapHeight / 2;
        check();
    }

    private void OnGUI()
    {
        keyUp = GUILayout.RepeatButton("向前移动");
        keyDown = GUILayout.RepeatButton("向后移动");
        keyRight = GUILayout.RepeatButton("向右移动");
        keyLeft = GUILayout.RepeatButton("向左移动");

        //小地图背景
        GUI.DrawTexture(new Rect(Screen.width - map.width, 0, map.width, map.height), map);
        GUI.DrawTexture(new Rect(mapCube_x, mapCube_y, mapCube.width, mapCube.height), mapCube);
    }


    private void check()
    {
        float x = cube.transform.position.x;
        float z = cube.transform.position.z;

        if(x >= widthCheck)
        {
            x = widthCheck;
        }
        if(x <= -widthCheck)
        {
            x = -widthCheck;
        }
        if(z >= heightCheck)
        {
            z = heightCheck;
        }
        if(z <= -heightCheck)
        {
            z = -heightCheck;
        }

        cube.transform.position = new Vector3(x, cube.transform.position.y, z);

        //根据比例计算小地图“主角”的坐标
        // Debug.Log(map.width / mapWidth + " " + x + " " + map.width);
        //Debug.Log(cube.transform.position.x + " "+ map.height / mapHeight);

        mapCube_x = (map.width / mapWidth * x) + ((map.width / 2) - (mapCube.width / 2)) + (Screen.width - map.width);
        mapCube_y = map.height - ((map.height / mapHeight * z) + (map.height / 2));

    }
    private void FixedUpdate()
    {
        if (keyUp)
        {
            //向前移动
            cube.transform.Translate(Vector3.forward * Time.deltaTime * 5);
            check();

        }

        if (keyDown)
        {
            //向后移动
            cube.transform.Translate(-Vector3.forward * Time.deltaTime * 5);
            check();
        }

        if (keyLeft)
        {
            //向左移动
            cube.transform.Translate(-Vector3.right * Time.deltaTime * 5);
            check();
        }

        if (keyRight)
        {
            //向右移动
            cube.transform.Translate(Vector3.right * Time.deltaTime * 5);
            check();
        }
    }

}
