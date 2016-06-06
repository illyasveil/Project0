﻿using UnityEngine;
using System.Collections;

public class AnimationMove : MonoBehaviour
{
	
	private Animator animator;
	
	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update()
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
	}
}