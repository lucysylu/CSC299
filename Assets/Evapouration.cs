using UnityEngine;
using System.Collections;

public class Evapouration : MonoBehaviour {

	public GameObject cloud;
	private Color color;
	public bool evap;

	void Update() { 
		if (Input.GetMouseButton (0)) {
			color = cloud.GetComponent<Renderer> ().material.color;
			color.a = 0.4f; color.r = 1; color.g = 1; color.b = 1;
			cloud.GetComponent<Renderer> ().material.color = color;
			evap = true;

		} else {
			color.a = 1.0f; color.r = 1; color.g = 1; color.b = 1;
			cloud.GetComponent<Renderer> ().material.color = color;
			evap = false;
		}

    }
}
