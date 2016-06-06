using UnityEngine;
using System.Collections;

public class scr_slider : MonoBehaviour {
public Hero hr;
public GameObject timer;
public int i;
	// Use this for initialization
	void Start () {
				i = (int)this.transform.position.x;
				Debug.Log ("i="+i.ToString());
				hr = MainData.current.hero[i];
				SpriteRenderer sr = GetComponent<SpriteRenderer>();
				sr.sprite = hr.avatar;
				timer = GameObject.Find ("Time");
	}
	
	// Update is called once per frame
	void Update () {
				//if (this.transform.position.x < hr.battleTime / 100 - 3.55f)
				//this.transform.position.x += this.transform.right * speed * Time.deltaTime;
				transform.position = new Vector3(hr.battleTime/15.0f + timer.transform.position.x - 3.3f, timer.transform.position.y+0.5f);

	}
}
