using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class ToggleVR : MonoBehaviour
{

	string message = "no input";

	void OnGUI()
	{
		GUI.Label(new Rect(10,10,200,30), message);
	}

	//Example of toggling VRSettings
	private void Update ()
	{
		//If V is pressed, toggle VRSettings.enabled
		if (Input.GetKeyDown(KeyCode.V) || (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended) )
		{
			VRSettings.enabled = !VRSettings.enabled;
			message = "Changed VR to:"+VRSettings.enabled;
			Debug.Log("Changed VRSettings.enabled to:"+VRSettings.enabled);
		}
	}
}
