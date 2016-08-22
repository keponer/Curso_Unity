using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class InterfaceAwake : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameManager.currentNumberStonesThrown = 0;
        GameManager.currentNumberStonesDestroyed = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Click()
    {
        SceneManager.LoadScene("stoneGame");
    }
}
