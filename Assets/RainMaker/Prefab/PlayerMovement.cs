using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public GameObject player;
	public Vector3 position;
	public bool rise;
	// Use this for initialization
	void Start () {
		position = new Vector3 (player.GetComponent<Rigidbody>().position.x, 0, 0);
	}

	// Update is called once per frame
	void Update () {
		position.x += Time.deltaTime * 1.5f;
		position.y = player.GetComponent<Rigidbody> ().position.y;
		position.z = player.GetComponent<Rigidbody> ().position.z;

		if (rise) {

			if (position.y < 46f) {
				position.y += Time.deltaTime * 5;
			}
			player.GetComponent<Rigidbody> ().useGravity = false;
		} else {
			player.GetComponent<Rigidbody> ().useGravity = true;
		}

		player.GetComponent<Rigidbody> ().position = position;
	}

}
