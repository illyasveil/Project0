
using UnityEngine;
using System.Collections;
public class CamMove : MonoBehaviour {
	public Transform target;
	
	public int distance = -10;
	public float lift = 0.0f;
	public int x1 = 0;
	public float speed1; 
	private Move m;
	int vec;

	void Start()
	{
        m = GameObject.Find("Player").GetComponent<Move>();
	}

	void LateUpdate () {
		//transform.position = new Vector3 (x1,lift+2.6f, distance) + target.position;
		if (transform.position.x < target.position.x) 
		{
			vec = 1;
		} 
		else if (transform.position.x > target.position.x) 
		{
			vec = -1;
		} 
		else 
		{
			vec = 0;
		}
		speed1 = (int)(Mathf.Abs(transform.position.x - target.position.x));
		if (speed1 >= m.speed)
			speed1 = m.speed+1;
		//transform.position += new Vector3(vec,0,0) * speed1 * Time.deltaTime;
		//transform.position = new Vector3(Mathf.Lerp(0, 50, speed1*Time.deltaTime), 0, 0);
		//transform.position += new Vector3(vec,0,0) * Time.deltaTime * 2;
		//transform.LookAt(target);
	}
}