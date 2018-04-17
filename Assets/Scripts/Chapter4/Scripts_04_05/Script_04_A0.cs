using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_A0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SendMessageUpwards("ReceiveSendMessage", "A0-----SendMessageUpwards()");
        //Debug.Log("2");
        //Debug.Log("3");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ReceiveSendMessage(string str)
    {
        Debug.Log("A0---Receive" + str);
    }

    void ReceiveBroadcastMessage(string str)
    {
        Debug.Log("A0---Receive" + str);
    }

    void ReceiveSendMessageUpwards(string str)
    {
        Debug.Log("A0---Receive" + str);
    }
}
