﻿using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

    public GameObject target;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - target.transform.position;

	}
	
	void LateUpdate () {
        transform.position = target.transform.position + offset;
	}
}
