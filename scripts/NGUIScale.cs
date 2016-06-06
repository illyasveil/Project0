using UnityEngine;
using System.Collections;

public class NGUIScale : MonoBehaviour {
	private float screenW, screenH;
	public float posx, posy, widt, heigh;
	private GUIStyle Sken;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		screenW = Screen.width;
		screenH = Screen.height;
	}
	void OnGUI (){
		//GUI.Box(Rect(screenW/posx, screenH/posy, screenW/widt, screenH/heigh),"Text",Sken);
	}
}
