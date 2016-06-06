using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {
	private GameObject hero;
	private Animator animator;
	int end = Animator.StringToHash("MyLayer.end");
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		hero = GameObject.Find("hero_1");
		if (hero.transform.localScale.x > 0)
			this.transform.position += new Vector3(-2f,1f,0f);
		else
			this.transform.position += new Vector3(2f,1f,0f);
	}
	
	// Update is called once per frame
	void Update () {
		AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
		if (stateInfo.nameHash == end)
			Destroy(GameObject.Find("Sphere 1(Clone)"));
	}
}
