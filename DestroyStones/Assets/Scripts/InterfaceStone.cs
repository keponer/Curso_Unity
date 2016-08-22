using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InterfaceStone : MonoBehaviour {

    public Text textThrown, textDestroyed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        textThrown.text = "Number of Stones: " + GameManager.currentNumberStonesThrown;
        textDestroyed.text = "Number of Stones: " + GameManager.currentNumberStonesDestroyed;

    }
}
