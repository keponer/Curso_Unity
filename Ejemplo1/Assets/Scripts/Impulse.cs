﻿using UnityEngine;
using System.Collections;

public class Impulse : MonoBehaviour {

    public float impulseForce = 10.0f;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(Vector3.up * impulseForce, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
        }
	}
}
