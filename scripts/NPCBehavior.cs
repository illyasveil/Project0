using UnityEngine;
using System.Collections;

public class NPCBehavior : MonoBehaviour {
	public GameObject panelDialog;
	public bool battle;
	public float range = 3, closeRange = 2;
	private bool myActive;
	private GameObject targetPlayer;
	// Use this for initialization
	void Start () {
		targetPlayer = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Mathf.Abs (this.transform.position.x - targetPlayer.transform.position.x) <= range)
		myActive = true;
		else
		{
			myActive = false;
		}
		if (myActive == true)
		{
			if (Mathf.Abs (this.transform.position.x - targetPlayer.transform.position.x) >= closeRange)
			panelDialog.SetActive (false);
			if (battle == true)
			{
				Application.LoadLevel("FightScene");
			}
			else
			{
				if (Input.GetKeyUp(KeyCode.Return))
				{
					if (panelDialog.activeSelf == true)
					{
						panelDialog.SetActive (false);
					}
					else
					{
						panelDialog.SetActive (true);
					}
				}
			}
		}
	}
}
