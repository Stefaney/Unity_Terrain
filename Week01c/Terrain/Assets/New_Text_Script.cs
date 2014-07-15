using UnityEngine;
using System.Collections;

public class New_Text_Script : MonoBehaviour {
	int characterCounter = 0;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		float random_number = Random.Range (0, 2);
		if (random_number == 0) 
			{
			GetComponent<TextMesh> ().text = GetComponent<TextMesh> ().text + "/";
			} 
		else  
			{
			GetComponent<TextMesh> ().text = GetComponent<TextMesh> ().text + "\\";
			}

		characterCounter++;

		if (characterCounter > 20) 
		{
			GetComponent<TextMesh> ().text = GetComponent<TextMesh> ().text + "\n";
			characterCounter = 0;
		}
	}
}
