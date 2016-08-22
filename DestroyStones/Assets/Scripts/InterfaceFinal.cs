using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceFinal : MonoBehaviour {
    public Text textThrown, textDestroyed;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        textThrown.text = "Number of Stones: " + GameManager.currentNumberStonesThrown;
        textDestroyed.text = "destroyed: " + GameManager.currentNumberStonesDestroyed;

    }

    public void Click()
    {
        SceneManager.LoadScene("Awake");

    }
}
