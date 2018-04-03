using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03_05 : MonoBehaviour
{
    private float verticalValue= 0.0F;
    private float horizontalValue = 0.0F; 
    

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
        verticalValue = GUI.VerticalSlider(new Rect(25, 25, 30, 100), verticalValue, 100.0F, 0.0F);  ;
        horizontalValue = GUI.HorizontalSlider(new Rect(50, 25, 100, 30), horizontalValue, 0.0F, 100.0F); ;

        GUI.Label(new Rect(10, 150, Screen.width, 30), "纵向进度: " + verticalValue + "%");
        GUI.Label(new Rect(10, 200, Screen.width, 30), "横向进度: " + horizontalValue + "%");
    }
}
