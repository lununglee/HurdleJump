﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	/** Game Config */
	Rigidbody	RB_Player;
	bool		b_IsOnGround = true;
	public bool	b_GameOver = false;
	[SerializeField] float	JumpForce = 30.0f;
	[SerializeField] float	GravityModifier = 10.0f;

	// Start is called before the first frame update
	void	Start()
	{
		RB_Player = GetComponent<Rigidbody>();
		Physics.gravity *= GravityModifier;
	}

	// Update is called once per frame
	void	Update()
	{
		InputHandler();
		GameEndHandler();
	}

	void	InputHandler()
	{
		if (Input.GetKeyDown(KeyCode.Space) && b_IsOnGround)
		{
			RB_Player.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
			b_IsOnGround = false;
		}
	}

	void	GameEndHandler()
	{
		if (b_GameOver)
		{
			Debug.Log("Game Over!");
		}
	}

	void	OnCollisionEnter(Collision CollisionObject)
	{
		if (CollisionObject.gameObject.CompareTag("Ground"))
		{
			b_IsOnGround = true;
		}
		if (CollisionObject.gameObject.CompareTag("Obstacle"))
		{
			b_GameOver = true;
		}
	}
}
