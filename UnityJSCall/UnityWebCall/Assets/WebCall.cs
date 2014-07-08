using UnityEngine;
using System.Collections;

public class WebCall : MonoBehaviour {

	// Use this for initialization
	void OnGUI() {
 		if (GUI.Button(new Rect(10, 70, 50, 30), "Click")){
			Application.ExternalCall( "UnityTest  ",10);  
 		}		
	}

	void MyFunction(string param)
	{
		Application.ExternalCall("console.log", param); 
	}
}
