using UnityEngine;
using System.Collections;

public class TextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Debug.Log("Hello, World!");

		GetComponent<TextMesh> ().text = "“Oh that the desert were my dwelling place,\n With only one fair spirit for my minster.\n " +
			"That I might forget the human race\n And hating no one, love her only.”\n -Lord Byron";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
