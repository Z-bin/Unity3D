using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_14 : MonoBehaviour
{

    // Use this for initialization
    IEnumerator Start()
    {
        return Test();
    }

    // update is called once per frame
    void update()
    {

    }
    IEnumerator Test()
    {

        Debug.Log("开始等待" + Time.time);
        yield return new WaitForSeconds(2);
        Debug.Log("结束等待" + Time.time);
    }
 
}

