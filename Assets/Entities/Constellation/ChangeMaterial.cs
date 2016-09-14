using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {

	public Material blueMaterial;
	public Material redMaterial;

	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)) {
			ChangeTo("red");
		}
	}

	public void ChangeTo(string color){
		if (color.Equals("red")) {
			gameObject.GetComponent<Renderer>().material  = redMaterial;
		}

		if (color.Equals("blue")) {
			gameObject.GetComponent<Renderer>().material  = blueMaterial;
		}
	}
}
