﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixDepth : MonoBehaviour {

	public bool fixEveryFrame;
	public int offset = 0;
	SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		sprite.sortingLayerName = "Player";
		sprite.sortingOrder = Mathf.RoundToInt (-transform.position.y * 100) + offset;
	}
	
	// Update is called once per frame
	void Update () {
		if (fixEveryFrame) {
			sprite.sortingOrder = Mathf.RoundToInt (-transform.position.y * 100) + offset;
		}
	}
}
