using UnityEngine;
using System.Collections;

public class MoveAnim : MonoBehaviour {
	public float timer = 0.0f;
	public float timerSphere = 0.0f;
	private Animator animator;
	public GameObject sphere;
	private bool sphereExist;
	int wait = Animator.StringToHash("MyLayer.hero_1_idle_wait");
	void Start ()
	{
		animator = this.GetComponent<Animator>();
	}
	void Update () 
	{
		var horizontal = Input.GetAxis("Horizontal");
		
		if (horizontal > 0) 
		{
			animator.SetInteger ("Run", 1);
		} 
		else if (horizontal < 0) 
		{
			animator.SetInteger ("Run", -1);
		} 
		else 
		{
			animator.SetInteger ("Run", 0);
		}
		AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
		if (stateInfo.nameHash == wait)
		{
			animator.SetBool ("Tired",false);
			timer = 0.0f;
			if (sphereExist == false)
			{
				timerSphere += Time.deltaTime;
				if (timerSphere >= 3.0f)
				{
					sphereExist = true;
					Instantiate(sphere,this.transform.position,Quaternion.identity);
					timerSphere = 0.0f;
				}
			}
			if (GameObject.Find("Sphere 1(Clone)") == null)
			sphereExist = false;
			else
			timerSphere = 0.0f;
		}
		else
			timerSphere = 0.0f;
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			this.transform.localScale =  new Vector3(-1f,1f,1);
			timer = 0.0f;
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.localScale =  new Vector3(1f,1f,1);
			timer = 0.0f;
		}
		else
		{
			timer += Time.deltaTime;
			if (timer >= 15.0f)
			{
				timer = 0.0f;
				animator.SetBool ("Tired",true);
			}
		}

	}
}

