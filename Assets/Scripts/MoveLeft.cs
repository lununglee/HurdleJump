﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
	[SerializeField] float	Speed = 10.0f;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(Vector3.left * Speed * Time.deltaTime);
	}
}