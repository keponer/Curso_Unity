using UnityEngine;
using System.Collections;

public class Move2 : MonoBehaviour {

    public float forceValue, jumpValue;
    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) < 0.01f){
            rigidbody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
           }
	}

    void FixedUpdate()
    {
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * forceValue);
    }
}
