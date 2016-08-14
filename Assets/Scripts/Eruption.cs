using UnityEngine;
using System.Collections;

public class Eruption : MonoBehaviour {

    public GameObject stone;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
	// Use this for initialization
	void Start () {
        StartCoroutine(ThrowStone());
	}
	
	// Update is called once per frame
	void Update () {

	}

    IEnumerator ThrowStone()
    {
        yield return new WaitForSeconds(2.0f);
        while (true)
        {
            Instantiate(stone, transform.position, Random.rotation);
            yield return new WaitForSeconds(fireRate);
        }
     }
}
