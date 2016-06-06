using UnityEngine;
using System.Collections;

public class MyUniqueInit : MonoBehaviour {
	public int i = 0;
	public int avatar_num = 8;
		public Sprite spr;
	// Use this for initialization
	void Start () {
				for (i = 0; i < avatar_num; i++) 
				{
					//if (Resources.Load<Sprite> ("avatar" + i) != null)
				//	MainData.current.hero[i].avatar = Resources.Load<Sprite> ("avatar" + i);
				}
				MainData.current.hero[0].avatar = spr;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
