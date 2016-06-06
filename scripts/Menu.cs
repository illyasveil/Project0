using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public GameObject m;
	private bool paused;
	void Start () {

	}

	void Resume () {
		if (m.activeSelf == true)
		{
			m.SetActive (false);
		}
		else
		{
			m.SetActive (true);
		}
		if(!paused){  
			Time.timeScale = 0;  
			paused=true;  
		}else{  
			Time.timeScale = 1;  
			paused=false;  
		}
		}

	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape) && (m != null))
		{
			Resume ();
			//print(m.activeSelf);
		}
	}
	void save()
	{
		SaveLoad.Save();
	}
	void exit()
	{
		Application.Quit ();
	}

}
