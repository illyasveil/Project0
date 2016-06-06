using UnityEngine;
using System.Collections;

public class scr_battle : MonoBehaviour {
		public bool battle = false, turn = false;
		public int chn, choose = 0;
		public GameObject slider_prefab;
		public Hero hr;
	// Use this for initialization
	void Start () {
				for (int i = 0; i < 4; i++) 
				{
						Instantiate (slider_prefab, new Vector3 (i, 0, 0), Quaternion.identity);
				}
				/*
				Debug.Log ("hr   "+hr.health.ToString());
				hr.health = 25;
				Debug.Log ("hr=25   "+hr.health.ToString());
				Debug.Log ("MDh   "+ MainData.current.hero[chn].health.ToString());
				*/
				battle = true;
	}
	
	// Update is called once per frame
	void Update () {
				
				if (battle == true)
						for (int i = 0; i < 4; i++)
						{
								chn = MainData.current.curHeroNum[i];
								hr = MainData.current.hero[chn];
								if (hr.health != 0 && turn == false)
								{
										if (hr.battleTime < 100)
												hr.battleTime += Mathf.Floor((float)hr.speed/5);
												//hr.battleTime += 1;
										else
										{
												hr.battleTime = 100;
										}

								}
								if (turn == true) {
										//m.SetActive(true);
										if ((Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.LeftArrow)) && choose > 0)
												choose -= 1;
										if ((Input.GetKeyUp (KeyCode.DownArrow) || Input.GetKeyUp (KeyCode.RightArrow)) && choose < 5)
												choose += 1;
								} else 
								{
										//m.SetActive(false);
								}
						}
	}
}
