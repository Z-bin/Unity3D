using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_C0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SendMessageUpwards("ReceiveSendMessage", "C0-----SendMessageUpwards()");
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void ReceiveSendMessage(string str)
    {
        Debug.Log("C0---Receive" + str);
    }

    void ReceiveBroadcastMessage(string str)
    {
        Debug.Log("C0---Receive" + str);
    }

    void ReceiveSendMessageUpwards(string str)
    {
        Debug.Log("C0---Receive" + str);
    }
}
