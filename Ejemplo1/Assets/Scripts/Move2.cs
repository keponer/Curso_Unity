using UnityEngine;
using System.Collections;

public class Move2 : MonoBehaviour {

    public float forceValue, jumpValue;
    private  Rigidbody rigidbodya;
    private  AudioSource audioa;

    // Use this for initialization
    void Start () {
        rigidbodya = GetComponent<Rigidbody>();
        audioa = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
	    if(Input.GetButtonDown("Jump") && Mathf.Abs(rigidbodya.velocity.y) < 0.01f){
            rigidbodya.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
            audioa.Play();
           }

        if (Input.touchCount == 1)
        {
            if (Input.touches[0].phase == TouchPhase.Began && Mathf.Abs(rigidbodya.velocity.y) < 0.01f)
            {
                rigidbodya.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
                audioa.Play();
            }
        }
    }

    void FixedUpdate()
    {
        rigidbodya.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * forceValue);
        rigidbodya.AddForce(new Vector3(Input.acceleration.x, 0, Input.acceleration.y) * forceValue);

    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            print("Collision");
            //Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        print("Enteras en la zona");

    }
}
