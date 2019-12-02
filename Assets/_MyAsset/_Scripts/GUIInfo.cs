using UnityEngine;
using System.Collections;


public class GUIInfo : MonoBehaviour {

	public Texture2D tex; // drag the texture here

	// Use this for initialization
	void Start () {
		Screen.SetResolution(1024, 768, true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		
		GUI.DrawTexture(new Rect(0,0,316,148),tex);
	}
}
