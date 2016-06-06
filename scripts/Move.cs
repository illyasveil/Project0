using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed = 5.0f;
	void Start ()
	{
	}
	void Update () 
    {
        if (Input.GetKey (KeyCode.RightArrow)) 
		{
			//this.transform.position += this.transform.right * speed * Time.deltaTime;
			this.transform.Translate(this.transform.right * speed * Time.deltaTime);
			//this.transform.position += new Vector3(Mathf.Lerp(0, 1, 5*Time.deltaTime), 0, 0);
		}
        else if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.position -= this.transform.right * speed * Time.deltaTime;
		}
	}
}

