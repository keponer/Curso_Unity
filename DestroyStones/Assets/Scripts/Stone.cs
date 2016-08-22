using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {

    public GameObject explosion;

    private const float yDie = -30.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(transform.position.y < yDie)
        {
            Destroy(gameObject);
        }
	}

    void OnMouseDown()
    {
        Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
        Destroy(gameObject);
        GameManager.currentNumberStonesDestroyed++;


    }
}
